using SistemaAsistencia.CapaModelo;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmPersonas : Form
    {
        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void FrmPersonas_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            CapaDatos.ClsPersonaBD clsPersona = new CapaDatos.ClsPersonaBD();
            dt = clsPersona.LlenarDatos();
            dataPersona.DataSource = dt;


            this.picturePeople.Image = Image.FromFile(@"C:\Users\PC01AQ\Desktop\SistemaAsistencia\SistemaAsistencia\Assets\gifPeople.gif");
            this.picturePeople.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaVistas.FrmAgregarPersona agregarPersona = new CapaVistas.FrmAgregarPersona();
            agregarPersona.Show();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClsImage image = new ClsImage();

            CapaVistas.FrmModificarPersona modificarPersona = new CapaVistas.FrmModificarPersona();
            modificarPersona.labelId.Text = dataPersona.CurrentRow.Cells[0].Value.ToString();
            modificarPersona.txtName.Text = dataPersona.CurrentRow.Cells[2].Value.ToString();
            modificarPersona.txtLastName.Text = dataPersona.CurrentRow.Cells[3].Value.ToString();
            modificarPersona.txtCorreo.Text = dataPersona.CurrentRow.Cells[4].Value.ToString();
            modificarPersona.txtTelefono.Text = dataPersona.CurrentRow.Cells[5].Value.ToString();
            modificarPersona.comboFuncionario.Text = dataPersona.CurrentRow.Cells[6].Value.ToString();
            modificarPersona.txtFicha.Text = dataPersona.CurrentRow.Cells[7].Value.ToString();
            modificarPersona.txtFile.Text = dataPersona.CurrentRow.Cells[8].Value.ToString();
            byte[] photoPerson = (byte[])dataPersona.CurrentRow.Cells[9].Value;
            modificarPersona.txtCodigo.Text = dataPersona.CurrentRow.Cells[10].Value.ToString();


            Image imagePerson = image.byteArrayToImage(photoPerson);
            modificarPersona.pictureUser.Image = imagePerson;
            modificarPersona.arrayImagenUser = photoPerson;
            modificarPersona.Show();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }
    }
}
