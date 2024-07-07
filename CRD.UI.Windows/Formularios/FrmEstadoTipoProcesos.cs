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
    public partial class FrmEstadoTipoProcesos : Form
    {
        private EstadoTipoProcesosController servicio;
        private EstadoTipoProcesosVistaModelo estadoTipoProcesosVM;
        public FrmEstadoTipoProcesos()
        {
            InitializeComponent();
            servicio = new EstadoTipoProcesosController();
            estadoTipoProcesosVM = new EstadoTipoProcesosVistaModelo();
            listarDatos();
        }
        public void listarDatos()
        {
            dgwLista.DataSource = servicio.ListarEstadoTipoProcesos();
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
            txtIdEstadoTipoProcesos.Text = "";
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            InsertarEstadoTipoProcesos();
        }
        public void InsertarEstadoTipoProcesos()
        {
            estadoTipoProcesosVM.Nombre = txtNombre.Text;
            estadoTipoProcesosVM.Descripcion = txtDescripcion.Text;
            estadoTipoProcesosVM.Activo = chkEstado.Checked;
            if (txtIdEstadoTipoProcesos.Text == "")
            {
                if (servicio.InsertarEstadoTipoProcesos(estadoTipoProcesosVM))
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
                estadoTipoProcesosVM.IdEstadoTipoProceso = int.Parse(txtIdEstadoTipoProcesos.Text);
                if (servicio.ActualizarEstadoTipoProcesos(estadoTipoProcesosVM))
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
                txtIdEstadoTipoProcesos.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[0].Value.ToString();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar Registro", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                servicio.EliminarEstadoTipoProcesos(int.Parse(txtIdEstadoTipoProcesos.Text));
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
