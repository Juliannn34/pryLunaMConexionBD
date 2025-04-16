using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryGestionDeInventario;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;

namespace pryLunaMConexionBD
{
    public partial class FrmInicio : MaterialForm
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
            clsConexionBD objConexion = new clsConexionBD();
            clsCategorias categorias;

            DataTable tablaCategorias = objConexion.ObtenerCategorias();

            // Convertir la tabla de categorías a una lista de strings
            List<string> listaCategorias = new List<string>();

            foreach (DataRow row in tablaCategorias.Rows)
            {
                listaCategorias.Add(row["Nombre"].ToString()); // Suponiendo que el campo se llama "Nombre"
            }

            // Crear la instancia de clsFiltros para eliminar duplicados y llenar el ComboBox
            categorias = new clsCategorias(listaCategorias);

            // Llenar el ComboBox con las categorías
            categorias.llenarCMB(cmbCategoriasContactoAgregar);
            categorias.llenarCMB(cmbCategoriaContactoModificar);

            // Opcional: Si querés actualizar la grilla con los contactos al iniciar
            dgvContactosAgregar.DataSource = objConexion.ObtenerContactos();
            dgvModificarContactos.DataSource = objConexion.ObtenerContactos();
            dgvEliminarContacto.DataSource = objConexion.ObtenerContactos();



        }

        

        private void tabPage1_Click(object sender, EventArgs e)
        {
            clsConexionBD objConectarBD = new clsConexionBD();

            objConectarBD.ConectarBD();
        }

        private void btnAgregarContacto_Click(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();

            objConexion.AgregarContacto(
                txtNombreContactoAgregar.Text,
                txtApellidoContactoAgregar.Text,
                txtTelefonoContactoAgregar.Text,
                txtCorreoContactoAgregar.Text,
                cmbCategoriasContactoAgregar.Text
            );

            // Refrescar grilla después de agregar
            dgvContactosAgregar.DataSource = objConexion.ObtenerContactos();

            // Limpiar campos
            txtNombreContactoAgregar.Clear();
            txtApellidoContactoAgregar.Clear();
            txtTelefonoContactoAgregar.Clear();
            txtCorreoContactoAgregar.Clear();
            cmbCategoriasContactoAgregar.SelectedIndex = -1;
        }


        private string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";
        
        //Modificar por Nombre
        private void btnModificarContacto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdContactoModificar.Text, out int idContacto))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            string nuevoNombre = txtNombreProdructoModificar.Text;

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Por favor, ingresa un nombre.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                sqlConnection.Open();
                string consulta = "UPDATE Contactos SET Nombre = @Nombre WHERE ID = @ID";

                using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                {
                    comando.Parameters.AddWithValue("@Nombre", nuevoNombre);
                    comando.Parameters.AddWithValue("@ID", idContacto);

                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Nombre modificado correctamente.");
                        dgvContactosAgregar.DataSource = new clsConexionBD().ObtenerContactos();
                        dgvModificarContactos.DataSource = new clsConexionBD().ObtenerContactos();
                        dgvEliminarContacto.DataSource = new clsConexionBD().ObtenerContactos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un contacto con ese ID.");
                    }
                }
            }
        }



        //Modificar por Apellido

        private void btnModificarApellidoContacto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdContactoModificar.Text, out int idContacto))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            string nuevoApellido = txtApellidoContactoModificar.Text;

            if (string.IsNullOrWhiteSpace(nuevoApellido))
            {
                MessageBox.Show("Por favor, ingresa un apellido.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                sqlConnection.Open();
                string consulta = "UPDATE Contactos SET Apellido = @Apellido WHERE ID = @ID";

                using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                {
                    comando.Parameters.AddWithValue("@Apellido", nuevoApellido);
                    comando.Parameters.AddWithValue("@ID", idContacto);
                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Apellido modificado correctamente.");
            dgvContactosAgregar.DataSource = new clsConexionBD().ObtenerContactos();
            dgvModificarContactos.DataSource = new clsConexionBD().ObtenerContactos();
            dgvEliminarContacto.DataSource = new clsConexionBD().ObtenerContactos();
        }


        //Modificar por Telefono
        private void btnModificarTelefonoContacto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdContactoModificar.Text, out int idContacto))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            string nuevoTelefono = txtTelefonoContactoModificar.Text;

            if (string.IsNullOrWhiteSpace(nuevoTelefono))
            {
                MessageBox.Show("Por favor, ingresa un teléfono.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                sqlConnection.Open();
                string consulta = "UPDATE Contactos SET Telefono = @Telefono WHERE ID = @ID";

                using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                {
                    comando.Parameters.AddWithValue("@Telefono", nuevoTelefono);
                    comando.Parameters.AddWithValue("@ID", idContacto);
                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Teléfono modificado correctamente.");
            dgvContactosAgregar.DataSource = new clsConexionBD().ObtenerContactos();
            dgvModificarContactos.DataSource = new clsConexionBD().ObtenerContactos();
            dgvEliminarContacto.DataSource = new clsConexionBD().ObtenerContactos();
        }


        //Modificar por Correo
        private void btnModificarCorreoContacto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdContactoModificar.Text, out int idContacto))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            string nuevoCorreo = txtCorreoContactoModificar.Text;

            if (string.IsNullOrWhiteSpace(nuevoCorreo))
            {
                MessageBox.Show("Por favor, ingresa un correo.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                sqlConnection.Open();
                string consulta = "UPDATE Contactos SET Correo = @Correo WHERE ID = @ID";

                using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                {
                    comando.Parameters.AddWithValue("@Correo", nuevoCorreo);
                    comando.Parameters.AddWithValue("@ID", idContacto);
                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Correo modificado correctamente.");
            dgvContactosAgregar.DataSource = new clsConexionBD().ObtenerContactos();
            dgvModificarContactos.DataSource = new clsConexionBD().ObtenerContactos();
            dgvEliminarContacto.DataSource = new clsConexionBD().ObtenerContactos();
        }


        //Modificar por Categoria
        private void btnModificarCategoriaContacto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdContactoModificar.Text, out int idContacto))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            if (cmbCategoriaContactoModificar.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una categoría.");
                return;
            }

            string nuevaCategoria = cmbCategoriaContactoModificar.SelectedItem.ToString();

            using (SqlConnection sqlConnection = new SqlConnection(cadenaConexion))
            {
                sqlConnection.Open();
                string consulta = "UPDATE Contactos SET CategoriaId = @CategoriaId WHERE ID = @ID";

                using (SqlCommand comando = new SqlCommand(consulta, sqlConnection))
                {
                    comando.Parameters.AddWithValue("@CategoriaId", nuevaCategoria);
                    comando.Parameters.AddWithValue("@ID", idContacto);
                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Categoría modificada correctamente.");
            dgvContactosAgregar.DataSource = new clsConexionBD().ObtenerContactos();
            dgvModificarContactos.DataSource = new clsConexionBD().ObtenerContactos();
            dgvEliminarContacto.DataSource = new clsConexionBD().ObtenerContactos();
        }


        //Eliminar por ID
        private void btnEliminarIdContacto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEliminarIdContacto.Text, out int idContacto))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            // Confirmación antes de eliminar
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este contacto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string consulta = "DELETE FROM Contactos WHERE ID = @ID";

                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID", idContacto);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Contacto eliminado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un contacto con ese ID.");
                        }
                    }
                }

                // Refrescar la grilla
                dgvContactosAgregar.DataSource = new clsConexionBD().ObtenerContactos();
                dgvModificarContactos.DataSource = new clsConexionBD().ObtenerContactos();
                dgvEliminarContacto.DataSource = new clsConexionBD().ObtenerContactos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el contacto: " + ex.Message);
            }
            dgvContactosAgregar.DataSource = new clsConexionBD().ObtenerContactos();
            dgvModificarContactos.DataSource = new clsConexionBD().ObtenerContactos();
            dgvEliminarContacto.DataSource = new clsConexionBD().ObtenerContactos();

        }





        private void RecargarGrillaContactos()
        {
            clsConexionBD conexion = new clsConexionBD();
            dgvContactosAgregar.DataSource = conexion.ObtenerContactos();
            dgvModificarContactos.DataSource = conexion.ObtenerContactos();
            dgvEliminarContacto.DataSource = conexion.ObtenerContactos();
        }

        private void btnRecargarGillaAgregar_Click(object sender, EventArgs e)
        {
            RecargarGrillaContactos();
            MessageBox.Show("Grilla actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecargarGrillaModificar_Click(object sender, EventArgs e)
        {
            RecargarGrillaContactos();
            MessageBox.Show("Grilla actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecargarEliminar_Click(object sender, EventArgs e)
        {
            RecargarGrillaContactos();
            MessageBox.Show("Grilla actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
