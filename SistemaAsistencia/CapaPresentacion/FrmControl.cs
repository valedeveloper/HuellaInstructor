using SistemaAsistencia.CapaModelo;
using SistemaAsistencia.CapaNegocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmControl : Form
    {

        public FrmControl()
        {
            InitializeComponent();
            Data = new AppData();
            Timer timer = new Timer();
            timer.Interval = 500; // Intervalo de tiempo en milisegundos
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        private AppData Data;
        string cedula = string.Empty;
        byte[] huella;
        byte[] photoPerson;


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (labelEstado.Visible == true)
            {
                labelEstado.Visible = false;
            }
            else
            {
                labelEstado.Visible = true;
            }
        }


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
                MessageBox.Show("Ingrese la cédula", "Notificación");
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
                    //clsPersona.EntradaPersona_db(idPersona);



                    //Funciona, solo es encontrar la manera de que actualice apenas se haya ejecutado el procedimiento almacenado
                    int estadoPerson = clsPersona.EntradaPersona_db(idPersona);
                    if (estadoPerson == 1)
                    {
                        this.labelEstado.ForeColor=Color.FromArgb(143, 199, 62);
                        this.labelEstado.Text = "Usted está entrando";
                    }
                    else
                    {
                        this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);

                        this.labelEstado.Text = "Usted está saliendo";
                    }
                }else
                {
                   this.labelEstado.ForeColor = Color.Red;
                    this.labelEstado.Text = "Usted no está en la base de datos";
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
            DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();

            //private DPFP.Gui.Verification.VerificationControl verificationControl1;


            //CapaDatos.ClsPersonaBD clsPersona = new CapaDatos.ClsPersonaBD();
            //DataTable dataControl = clsPersona.TraerCedulaYHuella();

            //huella = (byte[])dataControl.Rows[0][0];
            //cedula = dataControl.Rows[0][1].ToString();
            ClsConexion conexion = new ClsConexion();
            SqlCommand command = new SqlCommand("SELECT Cedula_Persona,Huella_Persona FROM PERSONAS", conexion.Conectar());
            SqlDataReader reader = command.ExecuteReader();
            cedula = string.Empty;

            while (reader.Read())
            {
                byte[] Huella = (byte[])reader["Huella_Persona"];
                cedula = reader["Cedula_Persona"].ToString();
                MemoryStream memoryStream = new MemoryStream(Huella);
                DPFP.Template tmpObj = new DPFP.Template();

                tmpObj.DeSerialize(memoryStream);
                if (tmpObj != null)
                {
                    ver.Verify(FeatureSet, tmpObj, ref res);
                    Data.IsFeatureSetMatched = res.Verified;
                    Data.FalseAcceptRate = res.FARAchieved;
                    if (res.Verified)
                    {
                        this.txtCedula.Text = cedula;


                        CapaDatos.ClsPersonaBD clsPersona = new CapaDatos.ClsPersonaBD();
                        DataTable dataControl = clsPersona.TraerPersonaCedula_db(this.txtCedula.Text);
                        idPersona = (int)dataControl.Rows[0][0];

                        this.txtName.Text = dataControl.Rows[0][1].ToString();
                        this.txtLastName.Text = dataControl.Rows[0][2].ToString();
                        this.txtFuncionario.Text = dataControl.Rows[0][3].ToString();
                        this.txtFicha.Text = dataControl.Rows[0][4].ToString();
                        photoPerson = (byte[])dataControl.Rows[0][5];
                        huella = (byte[])dataControl.Rows[0][6];
                        ClsImage image = new ClsImage();

                        this.picturePeople.Image = image.byteArrayToImage(photoPerson);
                        //clsPersona.EntradaPersona_db(idPersona);




                        //Funciona, solo es encontrar la manera de que actualice apenas se haya ejecutado el procedimiento almacenado
                        int estadoPerson = clsPersona.EntradaPersona_db(idPersona);
                        if (estadoPerson == 1)
                        {
                            this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);
                            this.labelEstado.Text = "Usted está entrando";
                        }
                        else
                        {
                            this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);
                            this.labelEstado.Text = "Usted está saliendo";
                        }
                        break;
                    }
                }
            }

            if (!res.Verified)
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
                this.labelEstado.ForeColor = Color.Red;
                this.labelEstado.Text = "Usted no está en la base de datos";



            }
        }
    }
}
