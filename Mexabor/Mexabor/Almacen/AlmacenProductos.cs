using Mexabor.CacheAplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mexabor.Almacen
{
    public partial class AlmacenProductos : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public AlmacenProductos()
        {
            InitializeComponent();
        }

        private void AlmacenProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            string query = "SELECT * FROM ProductosAlmacen";  // consulta a la base de datos

            // Conexión y comando para obtener los datos
            using (SQLiteConnection connection = new SQLiteConnection(cadena))
            {
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Asignamos el DataTable como el origen de datos del DataGridView
                dataGridView1.DataSource = dataTable;

                // Encontramos la columna "Empacado" en el DataGridView y la reemplazamos por un CheckBox
                int empacadoColumnIndex = dataGridView1.Columns["Empacado"].Index;

                // Crear la columna de tipo CheckBox
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Empacado";  // Nombre de la columna
                checkBoxColumn.Name = "Empacado";        // Nombre interno de la columna
                checkBoxColumn.TrueValue = true;         // Valor cuando es seleccionado (True)
                checkBoxColumn.FalseValue = false;       // Valor cuando no está seleccionado (False)

                // Insertamos la columna de CheckBox en la posición de "Empacado" en el DataGridView
                dataGridView1.Columns.RemoveAt(empacadoColumnIndex);  // Eliminamos la columna original "Empacado"
                dataGridView1.Columns.Insert(empacadoColumnIndex, checkBoxColumn);  // Insertamos el CheckBox en su lugar

                // Luego asignamos los valores de la base de datos a la columna de CheckBox
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Empacado"] != null && row.Cells["Empacado"].Value != DBNull.Value)
                    {
                        // Convertimos el valor de la columna "Empacado" (1 o 0) a booleano (true o false)
                        int empacadoValue = Convert.ToInt32(row.Cells["Empacado"].Value);
                        row.Cells["Empacado"].Value = empacadoValue == 1;  // Si es 1, marca el checkbox; si es 0, lo desmarca
                    }
                }
            }
        }

        private void ActualizarDatos()
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            // Lista de parámetros que se van a actualizar
            List<string> updates = new List<string>();

            // Iniciar la conexión a la base de datos
            using (SQLiteConnection connection = new SQLiteConnection(cadena))
            {
                connection.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;  // No actualizar la fila nueva (vacía)

                    // Obtener los valores de las celdas
                    int idProducto = Convert.ToInt32(row.Cells["Id"].Value);
                    string nombreProducto = row.Cells["Producto"].Value.ToString();
                    string folio = row.Cells["Folio"].ToString();
                    bool isEmpacado = Convert.ToBoolean(row.Cells["Empacado"].Value);
                    int empacadoValue = isEmpacado ? 1 : 0;
                    int calidad = Convert.ToInt32(row.Cells["Calidad"].Value);
                    string cantidadIdeal = row.Cells["CantidadIdeal"].Value.ToString();
                    string observaciones = row.Cells["Observaciones"].Value.ToString();

                    // Construir el comando UPDATE para esta fila (sin ejecutar todavía)
                    string update = "UPDATE ProductosAlmacen SET Producto = @nombre, " +
                                    "Folio = @folio, " +
                                    "Empacado = @empacado, " +
                                    "Calidad = @calidad, " +
                                    "CantidadIdeal = @cantidadIdeal, " +
                                    "Observaciones = @observaciones " +
                                    "WHERE Id = @Id;";

                    // Almacenar la actualización en la lista
                    updates.Add(update);
                }

                // Crear un único comando SQL para ejecutar todas las actualizaciones
                string finalQuery = string.Join(" ", updates);

                // Ejecutar todas las actualizaciones en un solo paso
                using (SQLiteCommand command = new SQLiteCommand(finalQuery, connection))
                {
                    // Añadir todos los parámetros para todas las filas
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idProducto = Convert.ToInt32(row.Cells["Id"].Value);
                        string nombreProducto = row.Cells["Producto"].Value.ToString();
                        string folio = row.Cells["Folio"].ToString();
                        bool isEmpacado = Convert.ToBoolean(row.Cells["Empacado"].Value);
                        int empacadoValue = isEmpacado ? 1 : 0;
                        int calidad = Convert.ToInt32(row.Cells["Calidad"].Value);
                        string cantidadIdeal = row.Cells["CantidadIdeal"].Value.ToString();
                        string observaciones = row.Cells["Observaciones"].Value.ToString();

                        // Agregar los parámetros
                        command.Parameters.AddWithValue("@Id", idProducto);
                        command.Parameters.AddWithValue("@nombre", nombreProducto);
                        command.Parameters.AddWithValue("@folio", folio);
                        command.Parameters.AddWithValue("@empacado", empacadoValue);
                        command.Parameters.AddWithValue("@calidad", calidad);
                        command.Parameters.AddWithValue("@cantidadIdeal", cantidadIdeal);
                        command.Parameters.AddWithValue("@observaciones", observaciones);
                    }

                    // Ejecutar el comando en bloque
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Estas seguro que deseas continuar?\n Asegurate de que las opciones esten correctamente seleccionadas", "Avanzar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.OK)
            {
                //ActualizarDatos();
                ConexionBD_Almacen.SubirDatos();
                ExportacionRestaurante exportacionFinal = new ExportacionRestaurante();
                exportacionFinal.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alma7Cajas almaCajas = new Alma7Cajas();
            almaCajas.Show();
            this.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
        }
    }
}
