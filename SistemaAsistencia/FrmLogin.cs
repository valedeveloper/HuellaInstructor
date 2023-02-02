using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAsistencia.CapaModelo;
using SistemaAsistencia.CapaDatos;
using SistemaAsistencia.CapaVistas;
namespace SistemaAsistencia
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ClsUsuarioBD validarExistencia = new ClsUsuarioBD();
            dt = validarExistencia.Loguearse_db(this.txtCedula.Text, this.txtPassword.Text);

            if (this.txtCedula.Text== "" || this.txtPassword.Text=="")
            {
                MessageBox.Show("Llene los datos requeridos","Notificación");

            }
            else
            {
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No es Usuario");
                }
                else
                {
                    string estadoUser = dt.Rows[0][1].ToString();
                    if (estadoUser == "Activo")
                    {
                            MessageBox.Show("Eres Admin");
                            FrmMenu menu = new FrmMenu();
                             menu.Show();
                            this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No tienes permiso");
                    }
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
