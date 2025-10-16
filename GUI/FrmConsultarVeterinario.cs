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
    public partial class FrmConsultarVeterinario: Form
    {
        VeterinarioService veterinarioService = new VeterinarioService();
        public FrmConsultarVeterinario()
        {
            InitializeComponent();
        }

        private void FrmConsultarVeterinario_Load(object sender, EventArgs e)
        {
            CargarVeterinarios();
        }

        private void CargarVeterinarios()
        {
            dgvVeterinarios.DataSource = veterinarioService.Consultar();
        }
    }
}
