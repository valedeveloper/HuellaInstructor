using SistemaAsistencia.CapaDatos;
using SistemaAsistencia.CapaModelo;
using System;
using System.Data;
using System.Windows.Forms;
namespace SistemaAsistencia
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public string nameUser;
        public string estadoUser;
        public byte[] photoUser;
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ClsUsuarioBD validarExistencia = new ClsUsuarioBD();
            dt = validarExistencia.Loguearse_db(this.txtCedula.Text, ValidarPassword.GetSHA256(this.txtPassword.Text));

            if (this.txtCedula.Text == "" || this.txtPassword.Text == "")
            {
                MessageBox.Show("Llene los datos requeridos", "Notificación");

            }
            else
            {
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No es Usuario");
                }
                else
                {
                    ClsImage clsImage = new ClsImage();
                    nameUser = dt.Rows[0][0].ToString();
                    estadoUser = dt.Rows[0][1].ToString();
                    photoUser = (byte[])dt.Rows[0][2];
                    if (estadoUser == "Activo")
                    {
                        MessageBox.Show("Eres Admin");
                        FrmMenu menu = new FrmMenu();
                        menu.labelNombre.Text = nameUser;
                        menu.pictureUser.Image = clsImage.byteArrayToImage(photoUser);
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsPunctuation(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }


            }
        }

        private void imageVisible_Click(object sender, EventArgs e)
        {
            if(this.txtPassword.UseSystemPasswordChar == false)
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
            this.imageVisible.Visible = false;
            this.imageInvisble.Visible = true;
            

        }

        private void imageInvisble_Click(object sender, EventArgs e)
        {
            this.imageVisible.Visible = true;
            this.imageInvisble.Visible = false;

            if (this.txtPassword.UseSystemPasswordChar == true)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
