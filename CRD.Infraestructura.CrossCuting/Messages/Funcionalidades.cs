using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRD.Infraestructura.CrossCuting.Messages
{
    public static class Funcionalidades
    {
        public static void LimpiarCampos(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.Controls.Count > 0)
                {
                    LimpiarCampos(c);
                }
            }
        }
    }
}
