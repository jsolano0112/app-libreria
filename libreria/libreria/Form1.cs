using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace libreria
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=DESKTOP-O5BFFDF; database=libreria; integrated security=true");
        libro lb = new libro();
        string ImageUrl = null;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            datosTablas();

            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
            //para guardar imagen
            Image img = pb_foto.Image;
            byte[] arreglo;
            ImageConverter convertidor = new ImageConverter();
            arreglo = (byte[])convertidor.ConvertTo(img, typeof(byte[]));

            //para guardar archivo
            byte[] archivo = null;
            Stream MyStream = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            MyStream.CopyTo(obj);
            archivo = obj.ToArray();

            lb.Titulo = txt_titulo.Text;
            lb.Categoria = cb_categoria.SelectedIndex;
            lb.Descripcion = txt_descrip.Text;
            lb.Imagen = arreglo;
            lb.Ruta = ImageUrl;
            lb.Documento = archivo;
            lb.Extension = openFileDialog1.SafeFileName;

            MessageBox.Show(lb.AgregarLibro());
            limpiar();
            datosTablas();






        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void boton_subirfoto_Click(object sender, EventArgs e)
        {
            //abrir el dialogo para que se pueda extraer el archivo
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
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
            //para guardar imagen
            Image img = pb_foto.Image;
            byte[] arreglo;
            ImageConverter convertidor = new ImageConverter();
            arreglo = (byte[])convertidor.ConvertTo(img, typeof(byte[]));

            //para guardar archivo
            byte[] archivo = null;
            Stream MyStream = openFileDialog1.OpenFile();
            MemoryStream obj = new MemoryStream();
            MyStream.CopyTo(obj);
            archivo = obj.ToArray();

            lb.Id = Int32.Parse(id.Text);
            lb.Titulo = txt_titulo.Text;
            lb.Categoria = cb_categoria.SelectedIndex;
            lb.Descripcion = txt_descrip.Text;
            lb.Imagen = arreglo;
            lb.Ruta = ImageUrl;
            lb.Documento = archivo;
            lb.Extension = openFileDialog1.SafeFileName;

            MessageBox.Show(lb.ActualizarLibro());
            limpiar();
            datosTablas();



        }

        private void datosTablas()
        {

            if (txt_buscar.Text == "")
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM libros", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();


                //Llenar la tabla
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            else
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM libros WHERE titulo LIKE '%" + txt_buscar.Text + "%'", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();


                //Llenar la tabla
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }


        }

        //para limpiar los campos cuando ya se haya guardado o actualizado
        private void limpiar()
        {
            txt_titulo.Text = "";
            cb_categoria.SelectedIndex = 0;
            txt_descrip.Text = "";
            pb_foto.Image = null;
            txt_rutaArchivo.Text = "";


        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

            lb.Id = Int32.Parse(id.Text);
            MessageBox.Show(lb.EliminarLibro());

            id.Text = "";
            datosTablas();
            conexion.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Para Eliminar o Editar tienes que colocar en este campo el id del libro.");
        }

  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_archivo_Click(object sender, EventArgs e)
        {
            //dialogo para escoger el archivo
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_rutaArchivo.Text = openFileDialog1.FileName;
            }
        }

        private void btn_descargar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                lb.Id = id;
                var Lista = new List<libro>();
                Lista = lb.FiltroLibros();

                foreach (libro item in Lista)
                {
                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + "/temp/";
                    string ubicacionCompleta = carpeta + item.Extension;


                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);


                    if (File.Exists(ubicacionCompleta))
                        File.Delete(ubicacionCompleta);

                    File.WriteAllBytes(ubicacionCompleta, item.Documento);
                    Process.Start(ubicacionCompleta);
                }
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            datosTablas();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void extraerImgDes()
        {


       
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //para agregar la descripción al campo de textos
            try
            {
                richTextBox1.Text = "";
                string descr = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                int idRow = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);

                id.Text = Convert.ToString(idRow);
              
                richTextBox1.AppendText(descr);

                conexion.Open();

                SqlCommand comando = new SqlCommand("SELECT img FROM libros WHERE id = '"+idRow+"'", conexion);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows) {
                    reader.Read();
                    MemoryStream ms  = new MemoryStream((byte[])reader["img"]);
                    Bitmap bm = new Bitmap(ms);
                    pb_extraer.Image = bm;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la imagen"+ex.ToString());
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
