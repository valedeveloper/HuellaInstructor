using SistemaAsistencia.CapaModelo;
♠using System.Data.SqlClient;

namespace SistemaAsistencia.CapaDatos
{
    public class ClsPersonaBD
    {

        public void AgregarPersona_db(byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string estado_Persona, string direccion_Imagen, byte[] photo)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaInsertar = "INSERT INTO PERSONAS (Huella_Persona,Nombre_Persona,Apellido_Persona,Correo_Persona,Celular_Persona,Funcionario_Persona,Ficha_Persona,Estado_Persona,Direccion_Persona,Photo_Persona) VALUES (@Huella_Persona,@Nombre_Persona,@Apellido_Persona,@Correo_Persona,@Celular_Persona,@Funcionario_Persona,@Ficha_Persona,@Estado_Persona,@Direccion_Persona,@Photo_Persona)";

            SqlCommand comandoInsertarPersonas = new SqlCommand(consultaInsertar, conexion.Conectar());

            comandoInsertarPersonas.Parameters.AddWithValue("@Huella_Persona", huellaPersona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Nombre_Persona", nombre);
            comandoInsertarPersonas.Parameters.AddWithValue("@Apellido_Persona", apellido);
            comandoInsertarPersonas.Parameters.AddWithValue("@Correo_Persona", correo);
            comandoInsertarPersonas.Parameters.AddWithValue("@Celular_Persona", celular);
            comandoInsertarPersonas.Parameters.AddWithValue("@Funcionario_Persona", funcionario_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Ficha_Persona", ficha_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Estado_Persona", estado_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("Direccion_Imagen", direccion_Imagen);
            comandoInsertarPersonas.Parameters.AddWithValue("Photo_Persona", photo);

            comandoInsertarPersonas.ExecuteNonQuery();
        }


        public void ModificarPersona_db(int id, byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string estado_Persona, string direccion_Imagen, byte[] photo)
        {
            ClsConexion conexion = new ClsConexion();

            string consultaModificar = "UPDATE PERSONAS SET Huella_Persona=@Huella_Persona,Nombre_Persona=@Nombre_Persona,Apellido_Persona=@Apellido_Persona,Correo_Persona=@Correo_Persona,Celular_Persona=@Celular_Persona,Funcionario_Persona=@Funcionario_Persona,Ficha_Persona=@Ficha_Persona,Estado_Persona=@Estado_Persona,Direccion_Imagen=@Direccion_Imagen,Photo_Persona=@Photo_Persona WHERE Id_Persona=@Id_Persona ";
            SqlCommand comandoModificar = new SqlCommand(consultaModificar, conexion.Conectar());
            comandoModificar.Parameters.AddWithValue("@Huella_Persona", huellaPersona);
            comandoModificar.Parameters.AddWithValue("@Nombre_Persona", nombre);
            comandoModificar.Parameters.AddWithValue("@Apellido_Persona", apellido);
            comandoModificar.Parameters.AddWithValue("@Correo_Persona", correo);
            comandoModificar.Parameters.AddWithValue("@Celular_Persona", celular);
            comandoModificar.Parameters.AddWithValue("@Funcionario_Persona", funcionario_Persona);
            comandoModificar.Parameters.AddWithValue("@Ficha_Persona", ficha_Persona);
            comandoModificar.Parameters.AddWithValue("@Estado_Persona", estado_Persona);
            comandoModificar.Parameters.AddWithValue("Direccion_Imagen", direccion_Imagen);
            comandoModificar.Parameters.AddWithValue("Photo_Persona", photo);
            comandoModificar.Parameters.AddWithValue("Id_Persona",id);

            comandoModificar.ExecuteNonQuery();
        }
    }
}
