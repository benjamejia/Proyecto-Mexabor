using System.Data;
using System.Data.SQLite;
using System.Configuration;
using Mexabor.CacheAplicacion;

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
                command.Parameters.AddWithValue("@Calidad", cbxCalidad.Text);
                command.Parameters.AddWithValue("@CantidadIdeal", txbCantidad.Text + comboBox1.Text);
                command.Parameters.AddWithValue("@Observaciones", rtbObservaciones.Text);
                command.Parameters.AddWithValue("@id", IdProducto);

                command.ExecuteNonQuery(); // Ejecuta la actualización
                conn.Close();
            }
        }
        private void LimpiarCampos()
        {
            txbProducto.Clear();
            txbFolio.Clear();
            checkBox1.Checked = false;
            cbxCalidad.Text = string.Empty;
            txbCantidad.Clear();
            rtbObservaciones.Clear();
        }
        /*
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];
                CacheFormsAlmacen datosFila = new CacheFormsAlmacen
                {
                    id = (int)Convert.ToInt64(filaSeleccionada.Cells["Id"].Value),
                    producto = filaSeleccionada.Cells["Producto"].Value.ToString(),
                    folio = (int)Convert.ToInt64(filaSeleccionada.Cells["Folio"].Value),
                    empacado = (int)Convert.ToInt64(filaSeleccionada.Cells["Empacado"].Value) == 1 ? true : false,
                    calidad = filaSeleccionada.Cells["Calidad"].Value.ToString(),
                    cantidad = filaSeleccionada.Cells["CantidadIdeal"].Value.ToString(),
                    observaciones = filaSeleccionada.Cells["Observaciones"].Value.ToString()
                };
                LimpiarCampos();
                IdProducto = datosFila.id;
                txbProducto.Text = datosFila.producto;
                txbFolio.Text = datosFila.folio.ToString();
                checkBox1.Checked = datosFila.empacado ? true : false;
                empacado = datosFila.empacado == true ? 1 : 0;
                cbxCalidad.Text = datosFila.calidad.ToString();
                txbCantidad.Text = datosFila.cantidad.ToString();
                rtbObservaciones.Text = datosFila.observaciones;
            }
        }*/

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.Show();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //verifica campos vacios
            if (txbProducto.Text == string.Empty ||
                txbFolio.Text == string.Empty ||
                checkBox1.Text == string.Empty ||
                cbxCalidad.Text == string.Empty ||
                txbCantidad.Text == string.Empty ||
                rtbObservaciones.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un producto");
            }
            else
            {
                //Metodo UPDATE para actualizar datos del prodcuto en la base de datos 
                ActualizarProducto();
                MessageBox.Show("¡Se ha actualizado el producto correctamente!.");
                CargarDatos();
            }
        }

        private void rtbObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxCalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
