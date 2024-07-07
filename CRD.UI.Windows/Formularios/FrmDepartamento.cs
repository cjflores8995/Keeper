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
    public partial class FrmDepartamento : Form
    {
        private DepartamentoController servicio;
        private DepartamentoVistaModelo departamentoVM;
        public FrmDepartamento()
        {
            InitializeComponent();
            servicio = new DepartamentoController();
            departamentoVM = new DepartamentoVistaModelo();
            listarDatos();
        }
        public void listarDatos()
        {
            dgwLista.DataSource = servicio.ListarDepartamento();
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            chkEstado.Checked = false;
            txtIdDepartamento.Text = "";
        }
        public void InsertarDepartamento()
        {
            departamentoVM.NombreDepartamento = txtNombre.Text;
            departamentoVM.Descripcion = txtDescripcion.Text;
            departamentoVM.Activo = chkEstado.Checked;

            if (txtIdDepartamento.Text == "")
            {
                if (servicio.InsertarDepartamento(departamentoVM))
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
                departamentoVM.IdDepartamento = int.Parse(txtIdDepartamento.Text);
                if (servicio.ActualizarDepartamento(departamentoVM))
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            InsertarDepartamento();
        }
        private void dgwLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int item = dgwLista.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (item > 0)
            {

                txtNombre.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[1].Value.ToString();
                txtDescripcion.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[2].Value.ToString();
                chkEstado.Checked = Boolean.Parse(dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[3].Value.ToString());
                txtIdDepartamento.Text = dgwLista.Rows[dgwLista.CurrentRow.Index].Cells[0].Value.ToString();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar Registro", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                servicio.EliminarDepartamento(int.Parse(txtIdDepartamento.Text));
                limpiar();
                listarDatos();
            }
        }
        private void FrmDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
