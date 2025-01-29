using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace Mexabor.Almacen
{
    public partial class Productos : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public Productos()
        {
            InitializeComponent();
            CargarDatos();
        }

        bool Modificacion = false;
        public int IdProducto = 1; // Inicializa el ID en 1
        int empacado;
        SQLiteConnection conn = new SQLiteConnection(cadena);
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
            }
        }
        // Método para actualizar los datos en la base de datos
        private void ActualizarProducto()
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                string consulta = "UPDATE productosAlmacen SET " +
                                  "Producto = @Producto, " +
                                  "Folio = @Folio, " +
                                  "Empacado = @Empacado, " +
                                  "Calidad = @Calidad, " +
                                  "CantidadIdeal = @CantidadIdeal, " +
                                  "Observaciones = @Observaciones " +
                                  "WHERE Id = @id";

                SQLiteCommand command = new SQLiteCommand(consulta, conn);
                command.Parameters.AddWithValue("@Producto", txbProducto.Text);
                command.Parameters.AddWithValue("@Folio", txbFolio.Text);
                command.Parameters.AddWithValue("@Empacado", empacado);
                command.Parameters.AddWithValue("@Calidad", txbCalidad.Text);
                command.Parameters.AddWithValue("@CantidadIdeal", txbCantidad.Text + comboBox1.Text);
                command.Parameters.AddWithValue("@Observaciones", rtbObservaciones.Text);
                command.Parameters.AddWithValue("@id", IdProducto);

                command.ExecuteNonQuery(); // Ejecuta la actualización
                conn.Close();
            }
        }
        private void MostrarProducto(int id)
        {
            // Asegurémonos de crear una nueva conexión y abrirla en cada llamada
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                // Consulta SQL con parámetros
                string consulta = "SELECT Producto, Folio, Empacado, Calidad, CantidadIdeal, Observaciones FROM productosAlmacen WHERE Id = @id";

                // Preparamos el comando
                SQLiteCommand command = new SQLiteCommand(consulta, conn);
                command.Parameters.AddWithValue("@id", id); // Asignamos el valor del ID a la consulta

                // Ejecutamos la consulta y obtenemos los datos
                SQLiteDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Si encontramos el producto, asignamos los valores a los controles
                    txbProducto.Text = reader["Producto"].ToString();
                    txbFolio.Text = reader["Folio"].ToString();
                    empacado = Convert.ToInt32(reader["Empacado"]);
                    checkBox1.Checked = empacado == 1 ? true : false;
                    txbCalidad.Text = reader["Calidad"].ToString();
                    txbCantidad.Text = reader["CantidadIdeal"].ToString();
                    rtbObservaciones.Text = reader["Observaciones"].ToString();
                    conn.Close();
                }
                else
                {
                    // Si no encontramos el producto, mostramos mensaje
                    MessageBox.Show("Producto no encontrado con el ID " + id.ToString());
                }
            } // El using garantiza que la conexión se cierra correctamente aquí
        }
        private void LimpiarCampos()
        {
            txbProducto.Clear();
            txbFolio.Clear();
            checkBox1.Checked = false;
            txbCalidad.Clear();
            txbCantidad.Clear();
            rtbObservaciones.Clear();

            // Reiniciamos el indicador de cambios
            Modificacion = false;
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Primero verificamos si hay cambios en los campos
            if (Modificacion == true)
            {
                // Preguntamos al usuario si desea guardar los cambios
                DialogResult result = MessageBox.Show("¿Realizaste cambios en los campos?", "Confirmar", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Si el usuario acepta, actualizamos los datos
                    ActualizarProducto();
                    MessageBox.Show("Producto actualizado.");
                    CargarDatos();
                }

                // Limpiamos los campos después de la actualización
                LimpiarCampos();
            }
            // Intentamos encontrar un producto válido con el ID actual
            MostrarProducto(IdProducto);

            // Incrementamos el ID para el siguiente producto
            IdProducto++;

            // Verificamos si ya no hay más productos
            if (IdProducto > 30) // Ajusta el límite a la cantidad total de productos en tu base de datos
            {
                MessageBox.Show("No hay más productos disponibles.");
                return; // Salimos del evento si no hay más productos
            }
        }

        private void txbProducto_TextChanged(object sender, EventArgs e)
        {
            Modificacion = true;
        }

        private void txbFolio_TextChanged(object sender, EventArgs e)
        {
            Modificacion = true;
        }

        private void txbEmpacado_TextChanged(object sender, EventArgs e)
        {
            Modificacion = true;
        }

        private void txbCalidad_TextChanged(object sender, EventArgs e)
        {
            Modificacion = true;
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            Modificacion = true;
        }

        private void rtbObservaciones_TextChanged(object sender, EventArgs e)
        {
            Modificacion = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Incrementamos el ID para el siguiente producto
            IdProducto--;
            // Intentamos encontrar un producto válido con el ID actual
            MostrarProducto(IdProducto);

            // Verificamos si ya no hay más productos
            if (IdProducto <= 1) // Ajusta el límite a la cantidad total de productos en tu base de datos
            {
                MessageBox.Show("No hay más productos disponibles.");
                return; // Salimos del evento si no hay más productos
            }
        }
    }
}
