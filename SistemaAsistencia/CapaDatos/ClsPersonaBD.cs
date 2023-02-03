using SistemaAsistencia.CapaModelo;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAsistencia.CapaDatos
{
    public class ClsPersonaBD
    {


        public DataTable LlenarDatos()
        {
            ClsConexion conexion = new ClsConexion();
            string consulta = "SELECT * FROM PERSONAS";
            SqlCommand sql = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }


        //public DataTable ValidacionPersona(int codigo_Barras)
        //{
        //    ClsConexion conexion = new ClsConexion();
        //    string consultaValidacionPersona = "SELECT Id_Persona FROM PERSONAS WHERE Codigo_Barras=@Codigo_Barras";
        //    SqlCommand sql = new SqlCommand(consultaValidacionPersona, conexion.Conectar());

        //    SqlDataAdapter sqlData = new SqlDataAdapter(sql);
        //    DataTable dataTable = new DataTable();
        //    sqlData.Fill(dataTable);
        //    return dataTable;
        //}
        public void AgregarPersona_db(byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string direccion_Imagen, byte[] photo, int codigo_Barras)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaInsertar = "INSERT INTO PERSONAS (Huella_Persona,Nombre_Persona,Apellido_Persona,Correo_Persona,Celular_Persona,Funcionario_Persona,Ficha_Persona,Direccion_Imagen,Photo_Persona,Codigo_Barras) VALUES (@Huella_Persona,@Nombre_Persona,@Apellido_Persona,@Correo_Persona,@Celular_Persona,@Funcionario_Persona,@Ficha_Persona,@Direccion_Imagen,@Photo_Persona,@Codigo_Barras)";

            SqlCommand comandoInsertarPersonas = new SqlCommand(consultaInsertar, conexion.Conectar());

            comandoInsertarPersonas.Parameters.AddWithValue("@Huella_Persona", huellaPersona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Nombre_Persona", nombre);
            comandoInsertarPersonas.Parameters.AddWithValue("@Apellido_Persona", apellido);
            comandoInsertarPersonas.Parameters.AddWithValue("@Correo_Persona", correo);
            comandoInsertarPersonas.Parameters.AddWithValue("@Celular_Persona", celular);
            comandoInsertarPersonas.Parameters.AddWithValue("@Funcionario_Persona", funcionario_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Ficha_Persona", ficha_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Direccion_Imagen", direccion_Imagen);
            comandoInsertarPersonas.Parameters.AddWithValue("@Photo_Persona", photo);
            comandoInsertarPersonas.Parameters.AddWithValue("@Codigo_Barras", codigo_Barras);

            comandoInsertarPersonas.ExecuteNonQuery();
        }


        public void ModificarPersona_db(int id, byte[] huellaPersona, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string direccion_Imagen, byte[] photo, int codigo_Barras)
        {
            ClsConexion conexion = new ClsConexion();

            string consultaModificar = "UPDATE PERSONAS SET Huella_Persona=@Huella_Persona,Nombre_Persona=@Nombre_Persona,Apellido_Persona=@Apellido_Persona,Correo_Persona=@Correo_Persona,Celular_Persona=@Celular_Persona,Funcionario_Persona=@Funcionario_Persona,Ficha_Persona=@Ficha_Persona,Direccion_Imagen=@Direccion_Imagen,Photo_Persona=@Photo_Persona,Codigo_Barras=@Codigo_Barras WHERE Id_Persona=@Id_Persona";
            SqlCommand comandoModificar = new SqlCommand(consultaModificar, conexion.Conectar());
            comandoModificar.Parameters.AddWithValue("@Huella_Persona", huellaPersona);
            comandoModificar.Parameters.AddWithValue("@Nombre_Persona", nombre);
            comandoModificar.Parameters.AddWithValue("@Apellido_Persona", apellido);
            comandoModificar.Parameters.AddWithValue("@Correo_Persona", correo);
            comandoModificar.Parameters.AddWithValue("@Celular_Persona", celular);
            comandoModificar.Parameters.AddWithValue("@Funcionario_Persona", funcionario_Persona);
            comandoModificar.Parameters.AddWithValue("@Ficha_Persona", ficha_Persona);
            comandoModificar.Parameters.AddWithValue("Direccion_Imagen", direccion_Imagen);
            comandoModificar.Parameters.AddWithValue("Photo_Persona", photo);
            comandoModificar.Parameters.AddWithValue("@Codigo_Barras", codigo_Barras);
            comandoModificar.Parameters.AddWithValue("Id_Persona", id);
            comandoModificar.ExecuteNonQuery();
        }
        public DataTable Validar_Codigo(int Codigo)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaValidar = "SELECT Id_Persona FROM PERSONAS WHERE Codigo_Barras=@Codigo_Barras";
            SqlCommand sqlValidar = new SqlCommand(consultaValidar, conexion.Conectar());
            sqlValidar.Parameters.AddWithValue("@Codigo_Barras", Codigo);


            SqlDataAdapter sqlData = new SqlDataAdapter(sqlValidar);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }

        public DataTable TraerPersonaCodigo_db(int codigo_Barras)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaTraer = "SELECT Nombre_Persona,Apellido_Persona,Funcionario_Persona,Ficha_Persona,Photo_Persona WHERE Codigo_Barras=@Codigo_Barras";
            SqlCommand sqlTraer = new SqlCommand(consultaTraer, conexion.Conectar());
            sqlTraer.Parameters.AddWithValue("Codigo_Barras", codigo_Barras);

            SqlDataAdapter sql = new SqlDataAdapter(sqlTraer);
            DataTable data = new DataTable();
            sql.Fill(data);
            return data;
        }

        public DataTable TraerPersonaHuella_db(byte Id_Huella)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaTraer = "SELECT Nombre_Persona,Apellido_Persona,Funcionario_Persona,Ficha_Persona,Photo_Persona WHERE Id_Huella=@Id_Huella";
            SqlCommand sqlTraer = new SqlCommand(consultaTraer, conexion.Conectar());
            sqlTraer.Parameters.AddWithValue("Codigo_Barras", Id_Huella);

            SqlDataAdapter sql = new SqlDataAdapter(sqlTraer);
            DataTable data = new DataTable();
            sql.Fill(data);
            return data;
        }


    }
}
