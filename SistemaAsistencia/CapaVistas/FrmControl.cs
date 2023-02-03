using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmControl : Form
    {
        public FrmControl()
        {
            InitializeComponent();
        }

        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("h:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            CapaVistas.FrmModificarPersona personas = new FrmModificarPersona();
            CapaDatos.ClsPersonaBD clsPersona = new CapaDatos.ClsPersonaBD();
            CapaModelo.ClsImage clsImage = new CapaModelo.ClsImage();
            DataTable dataControl=clsPersona.TraerPersonaCodigo_db(int.Parse(this.txtCodigo.Text));

            this.labelName.Text = dataControl.Rows[0][0].ToString();
            this.labelLastName.Text = dataControl.Rows[0][1].ToString();
            this.labelFuncionario.Text = dataControl.Rows[0][2].ToString();
            this.labelFicha.Text = dataControl.Rows[0][3].ToString();
        





        }
    }
}
