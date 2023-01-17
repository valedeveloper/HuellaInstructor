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
    public partial class ModificarPersona : Form
    {
        Byte[] arrayImagenUser;

        public ModificarPersona()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text == "")
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
                        if (this.txtCorreo.Text == "")
                        {
                            MessageBox.Show("Ingrese el correo de la Persona");
                        }
                        else
                        {
                            if (this.txtTelefono.Text == "")
                            {
                                MessageBox.Show("Ingrese el teléfono de la persona");

                            }
                            else
                            {
                                if (this.comboFuncionamiento.Text == "")
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
                                            dataTable = clsPersona.Validar_Codigo(int.Parse(this.txtCodigo.Text));
                                            int idPersona = int.Parse(dataTable.Rows[0][0].ToString());


                                            if (dataTable.Rows.Count == 0 || idPersona == int.Parse(this.labelId.Text))
                                            {
                                                idPersona = int.Parse(dataTable.Rows[0][0].ToString());
                                                clsPersona.ModificarPersona_db(int.Parse(this.labelId.Text), arrayImagenUser, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionamiento.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtCodigo.Text));

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
            }
            catch
            {

            }
            ClsImage imagenArray = new ClsImage();
            arrayImagenUser = imagenArray.ImageToByteArray(this.pictureUser.Image);
        }
    } 
} 



     
