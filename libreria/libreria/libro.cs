using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreria
{
    internal class libro
    {
        private int id;
        private string titulo;
        private int categoria;
        private string descripcion;
        private byte[] img;
        private string ruta;
        private byte[] documento;
        private string extension;

        SqlConnection conexion = new SqlConnection("server=DESKTOP-O5BFFDF; database=libreria; integrated security=true");

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public byte[] Imagen { get => img; set => img = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public byte[] Documento { get => documento; set => documento = value; }
        public string Extension { get => extension; set => extension = value; }

        public string AgregarLibro()
        {
            conexion.Open();
            string query = "INSERT INTO libros(titulo, categoria, descripcion, img, ruta, documento, extension) VALUES(@titulo, @categoria, @descripcion, @img, @ruta, @documento, @extension)";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@img", img);
            comando.Parameters.AddWithValue("@ruta", ruta);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@extension", extension);

            comando.ExecuteNonQuery();
            
            conexion.Close();
            return "Libro registrado.";

        }

        public string ActualizarLibro()
        {
            conexion.Open();
            //int flag = 0;
            string query = "UPDATE libros SET titulo = @titulo, categoria = @categoria, descripcion = @descripcion, img = @img, ruta = @ruta WHERE id = @id";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@img", img);
            comando.Parameters.AddWithValue("@ruta", ruta);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@extension", extension);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            //flag = comando.ExecuteNonQuery();

            //if (flag == 1)
            //{
            //    return "Libro actualizado.";
            //}
            //else
            //{
            //   return "Error al actualizar";
            //}


            //conexion.Close();

            conexion.Close();
            return "Libro actualizado.";
        }

        public string EliminarLibro()
        {
            conexion.Open();
            string query = "DELETE FROM libros WHERE id = @id";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            conexion.Close();
            return "Libro eliminado.";
        }

        public DataTable LibroPorNombre()
        {
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM libros WHERE id = @id", conexion);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@id", Id);
            SqlDataReader lector = comando.ExecuteReader();
            tabla.Load(lector);
            lector.Close();
            conexion.Close();
            return tabla;
        }

        public List<libro> FiltroLibros()
        {
            var tabla = LibroPorNombre();
            var infoLibro = new List<libro>();

            foreach(DataRow item in tabla.Rows)
            {
                infoLibro.Add(new libro
                {
                    Id = Convert.ToInt32(item[0]),
                    Titulo = item[1].ToString(),
                    Categoria = Convert.ToInt32(item[2]),
                    Descripcion = item[3].ToString(),
                    Imagen = (byte[])item[4],
                    Ruta = item[5].ToString(),
                    Documento = (byte[])item[6],
                    Extension = item[7].ToString(),
                });
            }

            return infoLibro;
        }

    }
}
