using SistemaAsistencia.CapaModelo;
using SistemaAsistencia.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            Data = new AppData();
        }
        private AppData Data;
        string cedula = string.Empty;
        byte[] huella;
        byte[] photoPerson;

        private void timerCurrent_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString();
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
            if (this.txtCedula.Text == "")
            {
                MessageBox.Show("Ingrese la cédula","Notificación");
            }
            else
            {
                DataTable dataControl = clsPersona.TraerPersonaCedula_db(this.txtCedula.Text);
                if (dataControl.Rows.Count != 0)
                {
                    idPersona = (int)dataControl.Rows[0][0];
                   
                    this.txtName.Text = dataControl.Rows[0][1].ToString();
                    this.txtLastName.Text = dataControl.Rows[0][2].ToString();
                    this.txtFuncionario.Text = dataControl.Rows[0][3].ToString();
                    this.txtFicha.Text = dataControl.Rows[0][4].ToString();
                    photoPerson = (byte[])dataControl.Rows[0][5];
                    huella = (byte[])dataControl.Rows[0][6];
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
                    this.txtNoDedo.Focus();
                }
            }

           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }

        private void panelControl_Resize(object sender, EventArgs e)
        {
            panelControl.Left = (Width - panelControl.Width) / 2;
            panelControl.Top = (Height - panelControl.Height) / 2;
        }

        private void verificationControl1_OnComplete(object Control, DPFP.FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            //DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            //DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();
 
            
            //CapaDatos.ClsPersonaBD clsPersona = new CapaDatos.ClsPersonaBD();
            //DataTable dataControl = clsPersona.TraerCedulaYHuella();

            //huella = (byte[])dataControl.Rows[0][0];
            //cedula = dataControl.Rows[0][1].ToString();
            //MemoryStream memoryStream = new MemoryStream(huella);
            //DPFP.Template tmpObj = new DPFP.Template();
            //tmpObj.DeSerialize(memoryStream);
            //if (tmpObj != null)
            //{
            //    ver.Verify(FeatureSet, tmpObj, ref res);
            //    Data.IsFeatureSetMatched = res.Verified;
            //    Data.FalseAcceptRate = res.FARAchieved;
            //    if (res.Verified)
            //    {

            //    }
            //}

            //if (!res.Verified)
            //{
            //    EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
            //}
        }
    }
}
