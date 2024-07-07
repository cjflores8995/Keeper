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
    public partial class FrmValijas : Form
    {
        private ValijasController servicio;
        private ValijasVistaModelo valijasVM;
        public FrmValijas()
        {
            InitializeComponent(); servicio = new ValijasController();
            valijasVM = new ValijasVistaModelo();
            listarDatos();
        }
        public void listarDatos()
        {
            dgwLista.DataSource = servicio.ListarValijas();
        }
        private void limpiar()
        {
            txtBitacora.Text = "";
            txtFecha.Text = "";
            txtOrigen.Text = "";
            txtRemitente.Text = "";
            txtCentro.Text = "";
            txtOBSV.Text = "";
            chkEstado.Checked = false;
            txtIdValijas.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            InsertarValijas();
        }
        public void InsertarValijas()
        {
            valijasVM.IdBitacora = int.Parse(txtBitacora.Text);
            valijasVM.Fecha = DateTime.Parse(txtFecha.Text);
            valijasVM.Origen = txtOrigen.Text;
            valijasVM.Remitente = txtRemitente.Text;
            valijasVM.Centro = txtCentro.Text;
            valijasVM.OBSV = txtOBSV.Text;
            valijasVM.Activo = chkEstado.Checked;
            if (txtIdValijas.Text == "")
            {
                if (servicio.InsertarValijas(valijasVM))
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
                valijasVM.IdValija = int.Parse(txtIdValijas.Text);
                if (servicio.ActualizarValijas(valijasVM))
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
                txtBitacora.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[1].Value.ToString();
                txtFecha.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[2].Value.ToString();
                txtOrigen.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[3].Value.ToString();
                txtRemitente.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[4].Value.ToString();
                txtCentro.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[5].Value.ToString();
                txtOBSV.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[6].Value.ToString();
                chkEstado.Checked = Boolean.Parse(dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[7].Value.ToString()); ;
                txtIdValijas.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[0].Value.ToString();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar Registro", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                servicio.EliminarValijas(int.Parse(txtIdValijas.Text));
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
