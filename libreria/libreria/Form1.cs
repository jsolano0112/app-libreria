using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreria
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-O5BFFDF; database=libreria; integrated security=true");
        string ImageUrl = null;
        public Form1()
        {
            InitializeComponent();

            datosTablas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = pb_foto.Image;
            byte[] arreglo;
            ImageConverter convertidor = new ImageConverter();
            arreglo = (byte[])convertidor.ConvertTo(img, typeof(byte[]));

            try
            {
                string query = "INSERT INTO libros(titulo, categoria, descripcion, img, ruta) VALUES(@titulo, @categoria, @descripcion, @imagen, @ruta)";
                conexion.Open();

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@titulo", txt_titulo.Text);
                comando.Parameters.AddWithValue("@categoria", cb_categoria.SelectedIndex);
                comando.Parameters.AddWithValue("@descripcion", txt_descrip.Text);
                comando.Parameters.AddWithValue("@imagen", arreglo);
                comando.Parameters.AddWithValue("@ruta", ImageUrl);
                comando.ExecuteNonQuery();
                MessageBox.Show("Libro registrado.");

                txt_titulo.Text = "";
                cb_categoria.SelectedIndex = 0;
                txt_descrip.Text = "";
                pb_foto.Image = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
           



        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void boton_subirfoto_Click(object sender, EventArgs e)
        {
            
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    ImageUrl = ofd.FileName;
                    pb_foto.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Image img = pb_foto.Image;
            byte[] arreglo;
            ImageConverter convertidor = new ImageConverter();
            arreglo = (byte[])convertidor.ConvertTo(img, typeof(byte[]));

            string query = "  UPDATE libros SET titulo = @titulo, categoria = @categoria, descripcion = @descripcion, img = @img, ruta = @ruta WHERE id = @id";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query,conexion);
            comando.Parameters.AddWithValue("@titulo", txt_titulo.Text);
            comando.Parameters.AddWithValue("@categoria", cb_categoria.SelectedIndex);
            comando.Parameters.AddWithValue("@descripcion", txt_descrip.Text);
            comando.Parameters.AddWithValue("@img", arreglo);
            comando.Parameters.AddWithValue("@ruta", ImageUrl);
            comando.Parameters.AddWithValue("@id", id.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Libro actualizado.");

        }

        private void datosTablas()
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM libros", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();

            //Llenar la tabla
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }
    }
}
