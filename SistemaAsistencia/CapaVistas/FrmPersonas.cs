using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAsistencia.CapaModelo;

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
            dt=clsPersona.LlenarDatos();
            dataPersonas.DataSource = dt;
        }

        private void dataPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CapaVistas.FrmAgregarPersona agregarPersona = new CapaVistas.FrmAgregarPersona();
            agregarPersona.Show();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CapaVistas.ModificarPersona modificarPersona = new CapaVistas.ModificarPersona();
            modificarPersona.labelId.Text = dataPersonas.CurrentRow.Cells[0].Value.ToString();
            modificarPersona.txtName.Text = dataPersonas.CurrentRow.Cells[2].Value.ToString();
            modificarPersona.txtLastName.Text = dataPersonas.CurrentRow.Cells[3].Value.ToString();
            modificarPersona.txtCorreo.Text = dataPersonas.CurrentRow.Cells[4].Value.ToString();
            modificarPersona.txtTelefono.Text = dataPersonas.CurrentRow.Cells[5].Value.ToString();
            modificarPersona.comboFuncionamiento.Text = dataPersonas.CurrentRow.Cells[6].Value.ToString();
            modificarPersona.txtFicha.Text = dataPersonas.CurrentRow.Cells[7].Value.ToString();
            modificarPersona.txtFile.Text = dataPersonas.CurrentRow.Cells[8].Value.ToString();
            byte[] photoPerson = (byte[])dataPersonas.CurrentRow.Cells[9].Value;
            ClsImage image = new ClsImage();
            Image imagePerson=image.byteArrayToImage(photoPerson);
            modificarPersona.pictureUser.Image = imagePerson;
            modificarPersona.txtCodigo.Text = dataPersonas.CurrentRow.Cells[10].Value.ToString();

            modificarPersona.Show();

        }
    }
}
