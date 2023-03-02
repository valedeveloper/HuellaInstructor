using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Reportes.FrmReportePersona frmReporteConsumo = new Reportes.FrmReportePersona();
            frmReporteConsumo.ShowDialog();
            frmReporteConsumo.Close();
        }
    }
}
