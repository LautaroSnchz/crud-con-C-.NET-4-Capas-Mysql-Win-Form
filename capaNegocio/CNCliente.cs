using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Windows.Forms;

namespace capaNegocio
{
    public class CNCliente
    {
        public bool ValidarDatos(CECliente cliente)
        {
            bool Resultado = true;

            if(cliente.Nombre == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El nombre es Obligatorio");
            }
            if (cliente.Apellido == string.Empty)
            {
                Resultado = false;
                MessageBox.Show("El Apellido es Obligatorio");
            }

            if(cliente.Foto == null)
            {
                Resultado = false;
                MessageBox.Show("La Foto es Obligatoria");
            }

            return Resultado;   
        }
    }
}
