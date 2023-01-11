using SistemaAsistencia.CapaDatos;
using SistemaAsistencia.CapaModelo;
using System;
using System.Data;
using System.Windows.Forms;


namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmModificarUsuario : Form
    {
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        ClsUsuarioBD agregarDB = new ClsUsuarioBD();
        ClsImage image = new ClsImage();
        Byte[] arrayImagenUser;



        private void btnModificar_Click(object sender, EventArgs e)
        {
            arrayImagenUser = image.ImageToByteArray(pictureUser.Image);
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Digite el Nombre de usuario", "Notificación");
                txtName.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.txtLastName.Text))
                {
                    MessageBox.Show("Digite el Apellido de usuario", "Notificación");
                    txtLastName.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.txtTelefono.Text))
                    {
                        MessageBox.Show("Digite el Teléfono de Usuario", "Notificación");
                        txtTelefono.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.combotxtRol.Text))
                        {
                            MessageBox.Show("Digite el Rol de Usuario", "Notificación");
                            combotxtRol.Focus();
                        }

                        else
                        {


                            if (string.IsNullOrEmpty(this.txtCorreo.Text))
                            {
                                MessageBox.Show("Digite el Correo de Usuario, no cumple como correo", "Notificación");
                                txtCorreo.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.txtPassword.Text))
                                {
                                    MessageBox.Show("Digite la Constraseña de Usuario", "Notificación");
                                    txtPassword.Focus();
                                }
                                else
                                {
                                    if (this.comboEstado.Text == "")
                                    {
                                        MessageBox.Show("Digite el estado del Usuario", "Notificación");
                                        comboEstado.Focus();
                                    }
                                    else
                                    {
                                        if (this.txtFile.Text == "")
                                        {
                                            MessageBox.Show("Escoja un foto");
                                        }
                                        else
                                        {
                                            CapaModelo.ClsUsuario clsUser = new CapaModelo.ClsUsuario();
                                            clsUser.ModificarUsuario_db(int.Parse(this.labelId.Text), this.txtCedula.Text, this.txtName.Text, txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.txtPassword.Text, this.combotxtRol.Text, this.comboEstado.Text, this.txtFile.Text, this.arrayImagenUser);


                                            CapaVistas.FrmUsuarios frmUser = new CapaVistas.FrmUsuarios();
                                            DataTable dataUser = new DataTable();
                                            dataUser = agregarDB.LlenarUsuarios();
                                            frmUser.dataUsuario.DataSource = dataUser;


                                            frmUser.Show();
                                            this.Hide();
                                        }
                                    }


                                }
                            }
                        }
                    }
                }
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsOpenDialogPicture abrirCadena = new ClsOpenDialogPicture(this.txtFile.Text, this.pictureUser.Image);
            try
            {
                this.txtFile.Text = abrirCadena.AbrirCadena(this.txtFile.Text);
                this.pictureUser.Image = abrirCadena.MostrarImagen(this.txtFile.Text);
            }
            catch
            {

            }
            ClsImage imagenArray = new ClsImage();
            arrayImagenUser = imagenArray.ImageToByteArray(this.pictureUser.Image);
        }
    }
}
