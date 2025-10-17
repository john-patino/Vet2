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
    public partial class FrmVeterinario: Form
    {
        VeterinarioService veterinarioService = new VeterinarioService();
        public FrmVeterinario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarGrilla();
        }

        private void Guardar()
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Id = int.Parse(txtCodigo.Text);
            veterinario.Nombre = txtNombre.Text;
            veterinario.Telefono = txtTelefono.Text;

            var mensaje = veterinarioService.Guardar(veterinario);
            MessageBox.Show(mensaje);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            new FrmConsultarVeterinario().ShowDialog();
        }

        private void FrmVeterinario_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            grilla.DataSource = veterinarioService.Consultar();
        }

        private void txtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCodigo.Text==string.Empty)
            {
                e.Cancel = true;
                epVeterinario.SetError(txtCodigo,"el codigo no puede ser vacio");
                btnGuardar.Enabled = false;
                txtCodigo.Focus();
            }
            else
            {
                btnGuardar.Enabled = true;
            }
        }
    }
}
