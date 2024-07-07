using CRD.UI.Windows.ControladorAplicacion;
using CRD.UI.Windows.VistaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRD.UI.Windows.Formularios
{
    public partial class FrmIva : Form
    {
        private IvaController servicio;
        private IvaVistaModelo ivaVM;
        public FrmIva()
        {
            InitializeComponent();
            servicio = new IvaController();
            ivaVM = new IvaVistaModelo();
            listarDatos();
        }
        public void listarDatos()
        {
            dgwLista.DataSource = servicio.ListarIva();
        }
        private void limpiar()
        {
            txtValorIva.Text = "";
            chkEstado.Checked = false;
            txtIdIva.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            InsertarIva();
        }
        public void InsertarIva()
        {
            ivaVM.ValorIva = int.Parse(txtValorIva.Text);
            ivaVM.Activo = chkEstado.Checked;
            if (txtIdIva.Text == "")
            {
                if (servicio.InsertarIva(ivaVM))
                {
                    MessageBox.Show("Registro Insertado Correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error: No se Insertado registro, consulte a su Administrador");
                }
            }
            else
            {
                ivaVM.IdIva = int.Parse(txtIdIva.Text);
                if (servicio.ActualizarIva(ivaVM))
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error: No se Actualizo el registro, consulte a su Administrador");
                }
            }
            listarDatos();
        }
        private void dgwLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = dgwLista.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (item > 0)
            {

                txtValorIva.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[1].Value.ToString();
                chkEstado.Checked = Boolean.Parse(dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[2].Value.ToString());
                txtIdIva.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[0].Value.ToString();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar Registro", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                servicio.EliminarIva(int.Parse(txtIdIva.Text));
                limpiar();
                listarDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
