using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAsistencia.CapaDatos;
using SistemaAsistencia.CapaModelo;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmAgregarUsuario : Form
    {
        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }
        ClsUsuarioBD agregarDB = new ClsUsuarioBD();

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
                                            validacionCedula=agregarDB.ValidarCedula_db(this.txtCedula.Text);

                                            if (validacionCedula.Rows.Count == 0)
                                            {
                                                agregarDB.AgregarUsuario_db(this.txtCedula.Text, this.txtName.Text, txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.txtPassword.Text, this.combotxtRol.Text, this.comboEstado.Text, this.txtFile.Text, this.arrayImagenUser);


                                                CapaVistas.FrmUsuarios frmUser = new CapaVistas.FrmUsuarios();
                                                DataTable dataUser = new DataTable();
                                                dataUser = agregarDB.LlenarUsuarios();
                                                frmUser.dataUsuario.DataSource = dataUser;

                                                frmUser.Show();
                                                this.Hide();
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
    }
}
