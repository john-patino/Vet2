using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPropietario: Form
    {
        PropietarioService propietarioService = new PropietarioService();
        public FrmPropietario()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            //validar
            var propietario = new Propietario();
            propietario.Id = Convert.ToInt16(txtCodigo.Text);
            propietario.Nombre = txtNombre.Text;
            propietario.Telefono = txtTelefono.Text;

            var mensaje = propietarioService.Guardar(propietario);

            MessageBox.Show(mensaje);
        }

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (txtTelefono.Text==string.Empty)
            {
                e.Cancel = true;
                epPropietario.SetError(txtTelefono, "el numero de telefono no puede estar en blanco");
                txtTelefono.Focus();
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                e.Cancel = true;
                epPropietario.SetError(txtCodigo, "el codigo no puede estar en blanco");
                btnGuardar.Enabled = false;
                txtCodigo.Focus();
            }
            else
            {
                btnGuardar.Enabled = true;
                e.Cancel = false;
            }
        }
    }
}
