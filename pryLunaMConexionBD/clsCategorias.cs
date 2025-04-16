using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLunaMConexionBD
{
    internal class clsCategorias
    {
        public List<string> list = new List<string>();

        public clsCategorias(List<string> datos)
        {
            list = crearListaNoRepetida(datos);
        }

        public void llenarCMB(ComboBox cmb)
        {
            cmb.Items.Clear();

            list.ForEach(elem =>
            {
                cmb.Items.Add(elem);
            });

        }

        public List<string> crearListaNoRepetida(List<string> lst)
        {
            List<string> aux = new List<string>();
            lst.ForEach(elem =>
            {
                if (!aux.Any(x => x.Equals(elem)))
                {
                    aux.Add(elem);
                }
            });

            return aux;
        }
    }
}
