using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAsistencia.CapaDatos;
using SistemaAsistencia.CapaModelo;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmModificarPersona : Form
    {
       public Byte[] arrayImagenUser;

        public FrmModificarPersona()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.txtNoDedo.Text == "")
            {
                MessageBox.Show("Ingrese el código de barras");
            }
            else
            {
                if (this.txtName.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre de la Persona");
                }
                else
                {
                    if (this.txtLastName.Text == "")
                    {
                        MessageBox.Show("Ingrese el apellido de la persona");
                    }
                    else
                    {
                        if (this.txtCorreo.Text == "" || ClsValidarCorreo.validarEmail(this.txtCorreo.Text) == false)
                        {
                            MessageBox.Show("Ingrese un correo válido");
                        }
                        else
                        {
                            if (this.txtTelefono.Text == "")
                            {
                                MessageBox.Show("Ingrese el teléfono de la persona");

                            }
                            else
                            {
                                if (this.comboFuncionario.Text == "")
                                {
                                    MessageBox.Show("Ingrese el rol del funcionario");
                                }
                                else
                                {
                                    if (this.txtFicha.Text == "")
                                    {
                                        MessageBox.Show("Ingrese la ficha");
                                    }
                                    else
                                    {
                                        if (this.txtFile.Text == "")
                                        {
                                            MessageBox.Show("Ingrese una imagen");
                                        }
                                        else
                                        {

                                            //ClsPersona clsPersona1 = new ClsPersona(arrayImagenUser, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionamiento.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtCodigo.Text));

                                            CapaDatos.ClsPersonaBD clsPersona = new CapaDatos.ClsPersonaBD();
                                            DataTable dataTable = new DataTable();
                                            DataTable data = new DataTable();
                                            dataTable = clsPersona.Validar_Codigo(int.Parse(this.txtNoDedo.Text));
                                            data = clsPersona.Validar_Cedula(this.txtCedula.Text);

                                            if (dataTable.Rows.Count == 0 || this.labelId.Text==(data.Rows[0][0].ToString()) ||  this.labelId.Text == (dataTable.Rows[0][0].ToString()))
                                            {
                                                clsPersona.ModificarPersona_db(int.Parse(this.labelId.Text), arrayImagenUser, this.txtCedula.Text,this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionario.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtNoDedo.Text));
                                               
                                                
                                                
                                                
                                                //Mensaje de Salida para que el usuario sepa que está agregado el Usuario 
                                                MessageBox.Show("Persona Modificada", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.txtNoDedo.Text = "";
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
                                                MessageBox.Show("Ya existe una persona con este código");
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.txtNoDedo.Text = "";
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {


        }

        private void FrmModificarPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
} 



     
