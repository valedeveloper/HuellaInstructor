using SistemaAsistencia.CapaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmControl : Form
    {
        
        public FrmControl()
        {
            InitializeComponent();
        }
        byte[] photoPerson;

        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("h:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();

        }
        int idPersona;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

            this.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            CapaVistas.FrmModificarPersona personas = new FrmModificarPersona();
            CapaDatos.ClsPersonaBD clsPersona = new CapaDatos.ClsPersonaBD();
            CapaModelo.ClsImage clsImage = new CapaModelo.ClsImage();
            if (this.txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese el código de barras","Notificación");
            }
            else
            {
                DataTable dataControl = clsPersona.TraerPersonaCodigo_db(int.Parse(this.txtCodigo.Text));
                if (dataControl.Rows.Count != 0)
                {
                    idPersona = (int)dataControl.Rows[0][0];
                    this.labelName.Text = dataControl.Rows[0][1].ToString();
                    this.labelLastName.Text = dataControl.Rows[0][2].ToString();
                    this.labelFuncionario.Text = dataControl.Rows[0][3].ToString();
                    this.labelFicha.Text = dataControl.Rows[0][4].ToString();
                    photoPerson = (byte[])dataControl.Rows[0][5];
                    ClsImage image = new ClsImage();

                    this.picturePeople.Image = image.byteArrayToImage(photoPerson);


                    clsPersona.EntradaPersona_db(idPersona);


                    //Funciona, solo es encontrar la manera de que actualice apenas se haya ejecutado el procedimiento almacenado
                    //DataTable dataEstado = clsPersona.TraerEstadoAsistencia_db(idPersona);
                    //if(dataEstado.Rows[0][0].ToString() == "0")
                    //{
                    //    this.labelEstado.Text = "Usted está entrando";
                    //}
                    //else
                    //{
                    //    this.labelEstado.Text = "Usted está saliendo";
                    //}
                }
                else
                {
                    MessageBox.Show("El código no pertenece a ninguna persona, vuelva a intentarlo", "Notificación");
                    this.txtCodigo.Focus();
                }
            }

           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }
    }
}
