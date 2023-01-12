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
            ClsUsuario validarExistencia = new ClsUsuario();
            dt = validarExistencia.Loguearse(this.txtCedula.Text, this.txtPassword.Text);


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No es Usuario");
            }
            else
            {
                string rolUser = dt.Rows[0][0].ToString();
                string estadoUser = dt.Rows[0][1].ToString();
                if (estadoUser == "Activo")
                {
                    if (rolUser == "ADMIN")
                    {
                        MessageBox.Show("Eres Admin");
                        CapaVistas.FrmUsuarios usuarios = new CapaVistas.FrmUsuarios();
                        usuarios.Show();
                        this.Hide();

                    }
                    else
                    {
                        if (rolUser == "GRABADOR")
                        {
                            MessageBox.Show("Eres digitador");
                        }
                        else
                        {
                            MessageBox.Show("Eres factu");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No tienes permiso");
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
        }
    }
}
