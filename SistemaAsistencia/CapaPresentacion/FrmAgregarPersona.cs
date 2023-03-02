using SistemaAsistencia.CapaDatos;
using SistemaAsistencia.CapaModelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmAgregarPersona : Form
    {
        Byte[] arrayImagenUser;
        public FrmAgregarPersona()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ClsOpenDialogPicture abrirCadena = new ClsOpenDialogPicture(this.txtFile.Text, this.pictureUser.Image);
            try
            {
                this.txtFile.Text = abrirCadena.AbrirCadena(this.txtFile.Text);
                this.pictureUser.Image = abrirCadena.MostrarImagen(this.txtFile.Text);

                ClsImage imagenArray = new ClsImage();
                arrayImagenUser = imagenArray.ImageToByteArray(this.pictureUser.Image);
            }
            catch
            {

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código de barras","Notificación");
            }
            else
            {
                if (this.txtName.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre de la Persona", "Notificación");
                }
                else
                {
                    if (this.txtLastName.Text == "")
                    {
                        MessageBox.Show("Ingrese el apellido de la persona", "Notificación");
                    }
                    else
                    {
                        if (this.txtCorreo.Text == "" || ClsValidarCorreo.validarEmail(this.txtCorreo.Text) == false)
                        {
                            MessageBox.Show("Ingrese un correo válido", "Notificación");
                        }
                        else
                        {
                            if (this.txtTelefono.Text == "")
                            {
                                MessageBox.Show("Ingrese el teléfono de la persona", "Notificación");

                            }
                            else
                            {
                                if (this.comboFuncionario.Text == "")
                                {
                                    MessageBox.Show("Ingrese el rol del funcionario", "Notificación");
                                }
                                else
                                {
                                    if (this.txtFicha.Text == "")
                                    {
                                        MessageBox.Show("Ingrese la ficha", "Notificación");
                                    }
                                    else
                                    {
                                        if (this.txtFile.Text == "")
                                        {
                                            MessageBox.Show("Ingrese una imagen", "Notificación");
                                        }
                                        else
                                        {

                                            //ClsPersona clsPersona1 = new ClsPersona(arrayImagenUser, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionamiento.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtCodigo.Text));
                                            ClsPersonaBD clsPersona = new ClsPersonaBD();
                                            DataTable data = new DataTable();
                                            data = clsPersona.Validar_Cedula(this.txtCedula.Text);
                                           
                                            if (data.Rows.Count == 0)
                                            {
                                                DataTable dataTable = new DataTable();
                                                dataTable = clsPersona.Validar_Codigo(int.Parse(this.txtCodigo.Text));

                                                if (dataTable.Rows.Count==0)
                                                {

                                                    clsPersona.AgregarPersona_db(arrayImagenUser, this.txtCedula.Text, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionario.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtCodigo.Text));


                                                    FrmPersonas frmPersonas = new FrmPersonas();
                                                    DataTable dataPeople = new DataTable();
                                                    dataPeople = clsPersona.LlenarDatos();
                                                    frmPersonas.dataPersona.DataSource = dataPeople;

                                                    //Mensaje de Salida para que el usuario sepa que está agregado el Usuario 
                                                    MessageBox.Show("Usuario Agregado", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.txtCodigo.Text = "";
                                                    this.txtName.Text = "";
                                                    this.txtLastName.Text = "";
                                                    this.txtCorreo.Text = "";
                                                    this.txtTelefono.Text = "";
                                                    this.comboFuncionario.Text = "";
                                                    this.txtFile.Text = "";
                                                    this.txtFicha.Text = "";
                                                    this.pictureUser.Image = null;

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Este código ya existe","Notificación");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya existe una persona con esta cédula");
                                                int idPersona = int.Parse(data.Rows[0][0].ToString());

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtCodigo.Text = "";
                this.txtName.Text = "";
                this.txtLastName.Text = "";
                this.txtCorreo.Text = "";
                this.txtTelefono.Text = "";
                this.comboFuncionario.Text = "";
                this.txtFile.Text = "";
                this.txtFicha.Text = "";
                this.pictureUser.Image = null;
                this.Hide();

            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFicha_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
    }
}
