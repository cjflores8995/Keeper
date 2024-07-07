using CRD.Infraestructura.CrossCuting.Messages;
using CRD.UI.Windows.ControladoresApp;
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
    public partial class FrmRegistroUsuario : Form
    {
        CRD_UsuariosControlador controlador;
        CRD_CargoControlador cargoControlador;
        CRD_DepartamentoControlador departamentoControlador;
        CRD_CiudadControlador ciudadControlador;
        CRD_UsuariosVistaModelo vistaModelo;

        public FrmRegistroUsuario()
        {
            InitializeComponent();
            controlador = new CRD_UsuariosControlador();
            cargoControlador = new CRD_CargoControlador();
            departamentoControlador = new CRD_DepartamentoControlador();
            ciudadControlador = new CRD_CiudadControlador();
            vistaModelo = new CRD_UsuariosVistaModelo();


            CargarCargos();
            CargarDepartamentos();
            CargarCiudades();

            ListarRegistros();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void InsertUpdate()
        {


            if (string.IsNullOrEmpty(txtId.Text))
            {
                vistaModelo = CrearObjeto();
                Insertar(vistaModelo);
                ListarRegistros();
            }
            else
            {
                var resultado = MessageBox.Show(CustomMessages.ConfirmacionActualizacion, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    vistaModelo = CrearObjeto(true);
                    bool result = true;// Actualizar(vistaModelo);

                    if (result)
                    {
                        Funcionalidades.LimpiarCampos(this);
                        ListarRegistros();
                    }
                }
                else
                {

                    Funcionalidades.LimpiarCampos(this);
                }
            }
        }

        private void Insertar(CRD_UsuariosVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || 
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtNombreUsuario.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPassword.Text)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ListarRegistros()
        {
            dgvLista.DataSource = controlador.ListarTodo();
        }

        #region Private Methods

        private void CargarCargos()
        {


            cbxCargo.DisplayMember = "Nombre";
            cbxCargo.ValueMember = "Id";

            cbxCargo.DataSource = cargoControlador.ListarTodo()
                .Select(c => new { 
                    Id = c.IdCargo,
                    Nombre = c.NombreCargo
                }).ToList();

            cbxCargo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CargarDepartamentos()
        {
            cbxDepartamento.DisplayMember = "Nombre";
            cbxDepartamento.ValueMember = "Id";

            cbxDepartamento.DataSource = departamentoControlador.ListarTodo()
                .Select(c => new {
                    Id = c.IdDepartamento,
                    Nombre = c.NombreDepartamento
                }).ToList();

            cbxDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCiudades()
        {
            cbxCiudad.DisplayMember = "Nombre";
            cbxCiudad.ValueMember = "Id";

            cbxCiudad.DataSource = ciudadControlador.ListarTodo()
                .Select(c => new {
                    Id = c.IdCiudad,
                    Nombre = c.NombreCiudad
                }).ToList();

            cbxCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private CRD_UsuariosVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_UsuariosVistaModelo resultado = new CRD_UsuariosVistaModelo();
            
            resultado.Nombre = txtNombre.Text;
            resultado.Apellido = txtApellido.Text;
            resultado.Email = txtEmail.Text;
            resultado.PasswordHash = txtPassword.Text;
            resultado.NombreUsuario = txtNombreUsuario.Text;
            resultado.IdCargo = (int)cbxCargo.SelectedValue;
            resultado.IdDepartamento = (int)cbxDepartamento.SelectedValue;
            resultado.IdCiudad = (int)cbxCiudad.SelectedValue;

            if (incluirId)
            {
                resultado.Id = int.Parse(txtId.Text);
            }

            return resultado;
        }

        #endregion Private Methods

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                CustomMessages.DebesLlenarCamposRequeridos();
            }
            else
            {
                InsertUpdate();
            }
        }
    }
}
