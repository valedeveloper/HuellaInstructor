using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {
            CapaVistas.FrmUsuarios usuario = new CapaVistas.FrmUsuarios();
            usuario.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

            CapaVistas.FrmPersonas personas = new CapaVistas.FrmPersonas();
            personas.Show();
            this.Hide();
        }

        private void imageControl_Click(object sender, EventArgs e)
        {
            CapaVistas.FrmControl frmControl = new CapaVistas.FrmControl();
            frmControl.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }

        private void imageReporte_Click(object sender, EventArgs e)
        {
            CapaPresentacion.FrmReportes reportes = new CapaPresentacion.FrmReportes();
            reportes.Show();
            this.Hide();
        }
    }
}
