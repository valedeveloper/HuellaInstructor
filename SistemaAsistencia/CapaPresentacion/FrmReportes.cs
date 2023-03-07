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
            Reportes.FrmReportePersona frmReportePersona= new Reportes.FrmReportePersona();
            frmReportePersona.ShowDialog();
            frmReportePersona.Close();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteDias frmReporteDias = new Reportes.FrmReporteDias();
            frmReporteDias.ShowDialog();
            frmReporteDias.Close();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteFicha frmReporteFicha = new Reportes.FrmReporteFicha();
            frmReporteFicha.ShowDialog();
            frmReporteFicha.Close();
        }
    }
}
