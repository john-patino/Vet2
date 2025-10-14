using BLL;
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
    public partial class FrmConsultarRazas: Form
    {
        RazaService razaService = new RazaService();
        public FrmConsultarRazas()
        {
            InitializeComponent();
        }

        private void FrmConsultarRazas_Load(object sender, EventArgs e)
        {
            CargarRazas();
        }

        void CargarRazas()
        {
            dgvRazas.DataSource = razaService.Consultar();
        }
    }
}
