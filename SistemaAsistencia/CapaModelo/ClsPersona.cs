using SistemaAsistencia.CapaDatos;
using System.Data;

namespace SistemaAsistencia.CapaModelo
{
    public class ClsPersona
    {

        private byte[] HuellaPersona { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Correo { get; set; }
        private string Celular { get; set; }
        private string Funcionario_Persona { get; set; }
        private string Ficha_Persona { get; set; }
        private string Direccion_Imagen { get; set; }
        private byte[] Photo { get; set; }
        private int Codigo_Barras { get; set; }

        public ClsPersona(byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string direccion_Imagen, byte[] photo, int codigo_barras)
        {
            HuellaPersona = huellaPersona;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Celular = celular;
            Funcionario_Persona = funcionario_Persona;
            Ficha_Persona = ficha_Persona;
            Direccion_Imagen = direccion_Imagen;
            Photo = photo;
            Codigo_Barras = codigo_barras;

        }
        public static DataTable ValidacionPersona(int codigo_Barras)
        {
            CapaDatos.ClsPersonaBD clsPersonaBD = new ClsPersonaBD();
            return clsPersonaBD.Validar_Codigo(codigo_Barras);
        }

        public static DataTable LlenarDatos()
        {
            CapaDatos.ClsPersonaBD clsPersona = new CapaDatos.ClsPersonaBD();
            return clsPersona.LlenarDatos();
        }

        public void AgregarPersona(byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string estado_Persona, string direccion_Imagen, byte[] photo, int codigo_Barras)
        {
            CapaDatos.ClsPersonaBD clsPersonaB = new ClsPersonaBD();
            clsPersonaB.AgregarPersona_db(huellaPersona, nombre, apellido, correo, celular, funcionario_Persona, ficha_Persona, direccion_Imagen, photo, codigo_Barras);
        }

        public void ModificarPersona(int id, byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string estado_Persona, string direccion_Imagen, byte[] photo, int codigo_Barras)
        {
            CapaDatos.ClsPersonaBD clsPersonaBD = new ClsPersonaBD();
            clsPersonaBD.ModificarPersona_db(id, huellaPersona, nombre, apellido, correo, celular, funcionario_Persona, ficha_Persona, direccion_Imagen, photo, codigo_Barras);
        }

        public DataTable TraerPersonaCodigo(int codigo_Barras)
        {
            ClsPersonaBD personaBD = new ClsPersonaBD();
            return personaBD.TraerPersonaCodigo_db(codigo_Barras);
        }

        public DataTable TraerPersonaHuella(byte Id_Huella)
        {
            ClsPersonaBD personaBD = new ClsPersonaBD();
            return personaBD.TraerPersonaHuella_db(Id_Huella);
        }
    }
}
