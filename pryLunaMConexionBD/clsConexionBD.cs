using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

using System.Windows.Forms;
using System.Data;

namespace pryGestionDeInventario
{
    internal class clsConexionBD
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";

        //conector
        SqlConnection coneccionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;


        public void ConectarBD()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();
                
                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }     

        }

        public DataTable ObtenerContactos()
        {
            DataTable tablaContactos = new DataTable();

            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "SELECT * FROM Contactos";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccionBaseDatos);
                    adaptador.Fill(tablaContactos);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener datos: " + error.Message);
            }

            return tablaContactos;
        }

        public void AgregarContacto(string nombre, string apellido, string telefono, string correo, string categoriaId)
        {
            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, CategoriaId) " +
                                      "VALUES (@Nombre, @Apellido, @Telefono, @Correo, @CategoriaId)";

                    using (comandoBaseDatos = new SqlCommand(consulta, coneccionBaseDatos))
                    {
                        comandoBaseDatos.Parameters.AddWithValue("@Nombre", nombre);
                        comandoBaseDatos.Parameters.AddWithValue("@Apellido", apellido);
                        comandoBaseDatos.Parameters.AddWithValue("@Telefono", telefono);
                        comandoBaseDatos.Parameters.AddWithValue("@Correo", correo);
                        comandoBaseDatos.Parameters.AddWithValue("@CategoriaId", categoriaId);

                        comandoBaseDatos.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Contacto agregado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar contacto: " + error.Message);
            }
        }


        public DataTable ObtenerCategorias()
        {
            DataTable tablaCategorias = new DataTable();

            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "SELECT Nombre FROM Categorias";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccionBaseDatos);
                    adaptador.Fill(tablaCategorias);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener categorías: " + error.Message);
            }

            return tablaCategorias;
        }


        public DataRow ObtenerContactoPorID(int id)
        {
            DataTable tabla = new DataTable();

            try
            {
                // Establecer la conexión con la base de datos
                using (SqlConnection coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();

                    // Consulta SQL para obtener el contacto por ID
                    string consulta = "SELECT * FROM Contactos WHERE ID = @ID";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, coneccionBaseDatos))
                    {
                        // Agregar el parámetro ID
                        adaptador.SelectCommand.Parameters.AddWithValue("@ID", id);

                        // Llenar el DataTable con los resultados de la consulta
                        adaptador.Fill(tabla);
                    }
                }

                // Si la tabla tiene al menos una fila, retornar la primera fila (el contacto)
                if (tabla.Rows.Count > 0)
                {
                    return tabla.Rows[0];
                }
                else
                {
                    // Si no se encontró un contacto, retornar null
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores en caso de problemas con la conexión o la consulta
                MessageBox.Show("Error al obtener contacto por ID: " + ex.Message);
                return null;
            }
        }


        public void ModificarContacto(int id, string nombre, string apellido, string telefono, string correo, string categoriaId)
        {
            try
            {
                using (coneccionBaseDatos = new SqlConnection(cadenaConexion))
                {
                    coneccionBaseDatos.Open();
                    string consulta = "UPDATE Contactos SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Correo = @Correo, CategoriaId = @CategoriaId WHERE ID = @ID";

                    using (comandoBaseDatos = new SqlCommand(consulta, coneccionBaseDatos))
                    {
                        comandoBaseDatos.Parameters.AddWithValue("@ID", id);
                        comandoBaseDatos.Parameters.AddWithValue("@Nombre", nombre);
                        comandoBaseDatos.Parameters.AddWithValue("@Apellido", apellido);
                        comandoBaseDatos.Parameters.AddWithValue("@Telefono", telefono);
                        comandoBaseDatos.Parameters.AddWithValue("@Correo", correo);
                        comandoBaseDatos.Parameters.AddWithValue("@CategoriaId", categoriaId);

                        comandoBaseDatos.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Contacto modificado correctamente.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al modificar contacto: " + error.Message);
            }
        }















    }
}
