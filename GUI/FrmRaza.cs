using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace GUI
{
    public partial class FrmRaza: Form
    {
        RazaService razaService = new RazaService();
        public FrmRaza()
        {
            InitializeComponent();
        }

        private void FrmRaza_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            Raza raza = new Raza(int.Parse(txtCodigo.Text), txtNombre.Text);
            var mensaje =razaService.Guardar(raza);
            MessageBox.Show(mensaje);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarRazas f = new FrmConsultarRazas();
            f.ShowDialog();
        }
    }
}
