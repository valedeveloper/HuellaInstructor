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
            ClsUsuarioBD agregarDB = new ClsUsuarioBD();
            agregarDB.AgregarUsuario_db(this.txtCedula.Text, this.txtName.Text, txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.txtPassword.Text, this.combotxtRol.Text, this.comboEstado.Text, this.txtFile.Text, this.arrayImagenUser);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClsOpenDialogPicture abrirCadena = new ClsOpenDialogPicture(this.txtFile.Text,this.pictureUser.Image);
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

        private void FrmAgregarUsuario_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_de_AsistenciaDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            //this.uSUARIOSTableAdapter.Fill(this.sistema_de_AsistenciaDataSet.USUARIOS);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
