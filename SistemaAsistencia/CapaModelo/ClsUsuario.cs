using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAsistencia.CapaDatos;

namespace SistemaAsistencia.CapaModelo
{
    public class ClsUsuario
    {
        

        public string Cedula { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }

        private string Password { get; set; }
        private string Rol_Usuario{get;set;}

        public string Estado { get; set; }
        public string Direccion_Foto { get; set; }
        public byte[] Photo { get; set; }


        //Este es el contructor de la clase "Usuario"
        public ClsUsuario(string cedula, string nombre, string apellido, string correo, string celular, string password, string rol_Usuario, string estado, string direccion_Foto, byte[] photo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Celular = celular;
            Password = password;
            Rol_Usuario = rol_Usuario;
            Estado = estado;
            Direccion_Foto = direccion_Foto;
            Photo = photo;
        }

   

        public DataTable LlenarUsuario()
        {
            ClsUsuarioBD llenarUsuario = new ClsUsuarioBD();
            return llenarUsuario.LlenarUsuarios();

        }
        public DataTable Loguearse(string Cedula, string Password)
        {
            ClsUsuarioBD validarUsuario = new ClsUsuarioBD();
            return  validarUsuario.Loguearse_db(Cedula,Password);
        }

        //Tiene un método, que es agregar Usuarios. Se trae la query de la CapaDatos. 
        public void AgregarUsuario(string cedula, string nombre, string apellido, string correo, string celular, string password, string rol_Usuario, string estado, string direccion_Foto, byte[] photo)
        {
            ClsUsuarioBD userDb = new ClsUsuarioBD();
            userDb.AgregarUsuario_db(cedula, nombre, apellido, correo, celular, password, rol_Usuario, estado, direccion_Foto, photo);
        }

        public void ModificarUsuario_db(int id, string cedula, string nombre, string apellido, string correo, string celular, string password, string rol_Usuario, string estado, string direccion_Foto, byte[] photo)
        {
            ClsUsuarioBD userDb = new ClsUsuarioBD();
            userDb.ModificarUsuario_db(id,cedula, nombre, apellido, correo, celular, password, rol_Usuario, estado, direccion_Foto, photo);
        }

        public DataTable ValidarCedula(string Cedula)
        {
            ClsUsuarioBD validarCedula = new ClsUsuarioBD();
            return validarCedula.ValidarCedula_db(Cedula);

        }
    }
}

