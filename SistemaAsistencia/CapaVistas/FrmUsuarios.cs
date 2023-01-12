using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaVistas
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();



        }
        CapaModelo.ClsImage imageUser = new CapaModelo.ClsImage();

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            CapaModelo.ClsUsuario data = new CapaModelo.ClsUsuario();
            dt = data.LlenarUsuario();
            dataUsuario.DataSource = dt;

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaVistas.FrmAgregarUsuario agregarUsuario = new CapaVistas.FrmAgregarUsuario();
            agregarUsuario.Show();
        }

        private void dataUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

                CapaVistas.FrmModificarUsuario modificarUser = new CapaVistas.FrmModificarUsuario();


                modificarUser.labelId.Text = dataUsuario.CurrentRow.Cells[0].Value.ToString();
                modificarUser.txtCedula.Text = dataUsuario.CurrentRow.Cells[1].Value.ToString();
                modificarUser.txtName.Text = dataUsuario.CurrentRow.Cells[2].Value.ToString();
                modificarUser.txtLastName.Text = dataUsuario.CurrentRow.Cells[3].Value.ToString();
                modificarUser.txtCorreo.Text = dataUsuario.CurrentRow.Cells[4].Value.ToString();
                modificarUser.txtTelefono.Text = dataUsuario.CurrentRow.Cells[5].Value.ToString();
                modificarUser.txtPassword.Text = dataUsuario.CurrentRow.Cells[6].Value.ToString();
                modificarUser.combotxtRol.Text = dataUsuario.CurrentRow.Cells[7].Value.ToString();
                modificarUser.comboEstado.Text = dataUsuario.CurrentRow.Cells[8].Value.ToString();
                modificarUser.txtFile.Text = dataUsuario.CurrentRow.Cells[9].Value.ToString();
                byte[] photoByte = (byte[])dataUsuario.CurrentRow.Cells[10].Value;

                Image imagenUserPhoto = imageUser.byteArrayToImage(photoByte);
                modificarUser.pictureUser.Image = imagenUserPhoto;
                modificarUser.Show();
        }
    }
}
