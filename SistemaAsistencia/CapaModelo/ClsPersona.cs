using SistemaAsistencia.CapaDatos;


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
        private string Estado_Persona { get; set; }
        private string Direccion_Imagen { get; set; }
        private byte[] Photo { get; set; }

        public ClsPersona(byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string estado_Persona, string direccion_Imagen, byte[] photo)
        {
            HuellaPersona = huellaPersona;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Celular = celular;
            Funcionario_Persona = funcionario_Persona;
            Ficha_Persona = ficha_Persona;
            Estado_Persona = estado_Persona;
            Direccion_Imagen = direccion_Imagen;
            Photo = photo;
        }

        public void AgregarPersona(byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string estado_Persona, string direccion_Imagen, byte[] photo)
        {
            CapaDatos.ClsPersonaBD clsPersonaB = new ClsPersonaBD();
            clsPersonaB.AgregarPersona_db(huellaPersona, nombre, apellido, correo, celular, funcionario_Persona, ficha_Persona, estado_Persona, direccion_Imagen, photo);
        }

        public void ModificarPersona(int id, byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string estado_Persona, string direccion_Imagen, byte[] photo)
        {
            CapaDatos.ClsPersonaBD clsPersonaBD = new ClsPersonaBD();
            clsPersonaBD.ModificarPersona_db(id, huellaPersona, nombre, apellido, correo, celular, funcionario_Persona, ficha_Persona, estado_Persona, direccion_Imagen, photo);
        }




    }


}
