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

namespace pryLunaMConexionBD
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsConexionBD objConectarBD = new clsConexionBD();

            objConectarBD.ConectarBD();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            clsConexionBD objConexion = new clsConexionBD();

            DataTable tabla = objConexion.ObtenerContactos();

            dgvGrilla.DataSource = tabla;
        }
    }
}
