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
    public partial class FrmEmpresas : Form
    {
        private EmpresasController servicio;
        private EmpresasVistaModelo empresasVM;
        public FrmEmpresas()
        {
            InitializeComponent();
            servicio = new EmpresasController();
            empresasVM = new EmpresasVistaModelo();
            listarDatos();
        }
        public void listarDatos()
        {
            dgwLista.DataSource = servicio.ListarEmpresas();
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
            txtIdEmpresas.Text = "";
            txtCodigo.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            InsertarEmpresas();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar Registro", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                servicio.EliminarEmpresas(int.Parse(txtIdEmpresas.Text));
                limpiar();
                listarDatos();
            }
        }
        public void InsertarEmpresas()
        {
            empresasVM.CodigoEmpresa = txtCodigo.Text;
            empresasVM.Nombre = txtNombre.Text;
            empresasVM.Descripcion = txtDescripcion.Text;
            empresasVM.Activo = chkEstado.Checked;
            if (txtIdEmpresas.Text == "")
            {
                if (servicio.InsertarEmpresas(empresasVM))
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
                empresasVM.IdEmpresa = int.Parse(txtIdEmpresas.Text);
                if (servicio.ActualizarEmpresas(empresasVM))
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

                txtNombre.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[1].Value.ToString();
                txtDescripcion.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[2].Value.ToString();
                chkEstado.Checked = Boolean.Parse(dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[3].Value.ToString());
                txtIdEmpresas.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[0].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
