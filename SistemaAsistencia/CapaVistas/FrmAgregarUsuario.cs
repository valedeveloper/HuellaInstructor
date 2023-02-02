using SistemaAsistencia.CapaModelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        Byte[] arrayImagenUser;
        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {

            ClsConexion conectar = new ClsConexion();
            conectar.Conectar();
            //En el evento Cargar, lleno el dataView
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsUsuario agregarDB = new ClsUsuario(this.txtCedula.Text, this.txtName.Text, txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.txtPassword.Text, this.combotxtRol.Text, this.comboEstado.Text, this.txtFile.Text, this.arrayImagenUser);

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
                                            validacionCedula = agregarDB.ValidarCedula(this.txtCedula.Text);

                                            if (validacionCedula.Rows.Count == 0)
                                            {
                                                agregarDB.AgregarUsuario(this.txtCedula.Text, this.txtName.Text, txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.txtPassword.Text, this.combotxtRol.Text, this.comboEstado.Text, this.txtFile.Text, this.arrayImagenUser);


                                                CapaVistas.FrmUsuarios frmUser = new CapaVistas.FrmUsuarios();
                                                DataTable dataUser = new DataTable();
                                                dataUser = agregarDB.LlenarUsuarios();
                                                frmUser.dataUsuario.DataSource = dataUser;





                                                //Mensaje de Salida para que el usuario sepa que está agregado el Usuario 
                                                MessageBox.Show("Usuario Agregado", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                                MessageBox.Show("Ya existe un Usuario con esta cédula");
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
                this.Hide();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureUser_Click(object sender, EventArgs e)
        {

        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgregarUsuario_Load_1(object sender, EventArgs e)
        {

        }

        private void combotxtRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void combotxtRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void combotxtRol_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
