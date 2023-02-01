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
        public Byte[] arrayImagenUser;



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
                                            DataTable validacionCedula = new DataTable();
                                            validacionCedula = agregarDB.ValidarCedula_db(this.txtCedula.Text);
                                            string idUsuario = validacionCedula.Rows[0][0].ToString();
                                            if (validacionCedula.Rows.Count== 0 || idUsuario==this.labelId.Text  )
                                            {
                                                CapaDatos.ClsUsuarioBD clsUser = new CapaDatos.ClsUsuarioBD();
                                                clsUser.ModificarUsuario_db(int.Parse(this.labelId.Text), this.txtCedula.Text, this.txtName.Text, txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.txtPassword.Text, this.combotxtRol.Text, this.comboEstado.Text, this.txtFile.Text, this.arrayImagenUser);


                                                CapaVistas.FrmUsuarios frmUser = new CapaVistas.FrmUsuarios();
                                                DataTable dataUser = new DataTable();
                                                dataUser = agregarDB.LlenarUsuarios();
                                                frmUser.dataUsuario.DataSource = dataUser;


                                                frmUser.Show();
                                                this.Hide();


                                                MessageBox.Show("Usuario Modificado", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.txtCedula.Text = "";
                                                this.txtName.Text = "";
                                                this.txtLastName.Text = "";
                                                this.txtCorreo.Text = "";
                                                this.txtTelefono.Text = "";
                                                this.txtPassword.Text = "";
                                                this.txtFile.Text = "";
                                                this.combotxtRol.Text = "";
                                                this.comboEstado.Text = "";
                                                this.pictureUser.Image = null;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya existe usuario con esta cédula");
                                            }
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

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtCedula.Text = "";
                this.txtName.Text = "";
                this.txtLastName.Text = "";
                this.txtCorreo.Text = "";
                this.txtTelefono.Text = "";
                this.txtPassword.Text = "";
                this.txtFile.Text = "";
                this.combotxtRol.Text = "";
                this.comboEstado.Text = "";
                this.pictureUser.Image = null;

            }
        }
    }
}
