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

        public DataTable TraerCedulaYHuella()
        {
            ClsConexion conexion = new ClsConexion();
            string consulta = "SELECT Huella_Persona, Cedula_Persona FROM PERSONAS";
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
        public void AgregarPersona_db(byte[] huellaPersona, string cedula,string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string direccion_Imagen, byte[] photo, int no_dedo)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaInsertar = "INSERT INTO PERSONAS (Huella_Persona,Cedula_Persona,Nombre_Persona,Apellido_Persona,Correo_Persona,Celular_Persona,Funcionario_Persona,Ficha_Persona,Direccion_Imagen,Photo_Persona,No_Dedo) VALUES (@Huella_Persona,@Cedula_Persona,@Nombre_Persona,@Apellido_Persona,@Correo_Persona,@Celular_Persona,@Funcionario_Persona,@Ficha_Persona,@Direccion_Imagen,@Photo_Persona,@No_Dedo)";

            SqlCommand comandoInsertarPersonas = new SqlCommand(consultaInsertar, conexion.Conectar());

            comandoInsertarPersonas.Parameters.AddWithValue("@Huella_Persona", huellaPersona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Cedula_Persona", cedula);
            comandoInsertarPersonas.Parameters.AddWithValue("@Nombre_Persona", nombre);
            comandoInsertarPersonas.Parameters.AddWithValue("@Apellido_Persona", apellido);
            comandoInsertarPersonas.Parameters.AddWithValue("@Correo_Persona", correo);
            comandoInsertarPersonas.Parameters.AddWithValue("@Celular_Persona", celular);
            comandoInsertarPersonas.Parameters.AddWithValue("@Funcionario_Persona", funcionario_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Ficha_Persona", ficha_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Direccion_Imagen", direccion_Imagen);
            comandoInsertarPersonas.Parameters.AddWithValue("@Photo_Persona", photo);
            comandoInsertarPersonas.Parameters.AddWithValue("@No_Dedo", no_dedo);

            comandoInsertarPersonas.ExecuteNonQuery();
        }


        public void ModificarPersona_db(int id, byte[] huellaPersona, string cedula, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string direccion_Imagen, byte[] photo, int no_dedo)
        {
            ClsConexion conexion = new ClsConexion();

            string consultaModificar = "UPDATE PERSONAS SET Huella_Persona=@Huella_Persona,Cedula_Persona=@Cedula_Persona,Nombre_Persona=@Nombre_Persona,Apellido_Persona=@Apellido_Persona,Correo_Persona=@Correo_Persona,Celular_Persona=@Celular_Persona,Funcionario_Persona=@Funcionario_Persona,Ficha_Persona=@Ficha_Persona,Direccion_Imagen=@Direccion_Imagen,Photo_Persona=@Photo_Persona,No_Dedo=@No_dedo WHERE Id_Persona=@Id_Persona";
            SqlCommand comandoModificar = new SqlCommand(consultaModificar, conexion.Conectar());
            comandoModificar.Parameters.AddWithValue("@Huella_Persona", huellaPersona);
            comandoModificar.Parameters.AddWithValue("@Cedula_Persona", cedula);
            comandoModificar.Parameters.AddWithValue("@Nombre_Persona", nombre);
            comandoModificar.Parameters.AddWithValue("@Apellido_Persona", apellido);
            comandoModificar.Parameters.AddWithValue("@Correo_Persona", correo);
            comandoModificar.Parameters.AddWithValue("@Celular_Persona", celular);
            comandoModificar.Parameters.AddWithValue("@Funcionario_Persona", funcionario_Persona);
            comandoModificar.Parameters.AddWithValue("@Ficha_Persona", ficha_Persona);
            comandoModificar.Parameters.AddWithValue("Direccion_Imagen", direccion_Imagen);
            comandoModificar.Parameters.AddWithValue("Photo_Persona", photo);
            comandoModificar.Parameters.AddWithValue("@No_Dedo", no_dedo);
            comandoModificar.Parameters.AddWithValue("Id_Persona", id);
            comandoModificar.ExecuteNonQuery();
        }

        public void EntradaPersona_db(int id)
        {
            ClsConexion conexion = new ClsConexion();
            SqlCommand command = new SqlCommand("RegistroAsistenciaHuella", conexion.Conectar());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id_Persona", id);
            command.BeginExecuteNonQuery();
        }

        public DataTable Validar_Codigo(int no_dedo)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaValidar = "SELECT Id_Persona FROM PERSONAS WHERE No_Dedo=@No_Dedo";
            SqlCommand sqlValidar = new SqlCommand(consultaValidar, conexion.Conectar());
            sqlValidar.Parameters.AddWithValue("@No_Dedo", no_dedo);


            SqlDataAdapter sqlData = new SqlDataAdapter(sqlValidar);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }
        public DataTable Validar_Cedula(string cedula)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaValidar = "SELECT Id_Persona FROM PERSONAS WHERE Cedula_Persona=@Cedula_Persona";
            SqlCommand sqlValidar = new SqlCommand(consultaValidar, conexion.Conectar());
            sqlValidar.Parameters.AddWithValue("@Cedula_Persona", cedula);


            SqlDataAdapter sqlData = new SqlDataAdapter(sqlValidar);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }


        public DataTable TraerPersonaCedula_db(string cedula)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaTraer = "SELECT Id_Persona,Nombre_Persona,Apellido_Persona,Funcionario_Persona,Ficha_Persona,Photo_Persona,Huella_Persona FROM PERSONAS WHERE Cedula_Persona=@Cedula_Persona";
            SqlCommand sqlTraer = new SqlCommand(consultaTraer, conexion.Conectar());
            sqlTraer.Parameters.AddWithValue("Cedula_Persona", cedula);

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

        public DataTable TraerEstadoAsistencia_db(int id)
        {
            //Primero instanciamos la clase de conexión
            ClsConexion conexion = new ClsConexion();

            //Luego creamos la query
            string queryAsistencia = "SELECT Estado_Persona from ASISTENCIA_HUELLA WHERE Id_Asistencia = (SELECT MAX(Id_Asistencia) FROM ASISTENCIA_HUELLA where Id_Persona =@Id_Persona)";

            SqlCommand sql = new SqlCommand(queryAsistencia, conexion.Conectar());
            sql.Parameters.AddWithValue("Id_Persona", id);
            sql.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            return data;
        }

        public DataTable ReporteAsistencia_db()
        {
            ClsConexion conexion = new ClsConexion();
            string queryReporte = "SELECT P.Nombre_Persona, P.Apellido_Persona, A.Fecha_Entrada,A.Fecha_Salida FROM PERSONAS P INNER JOIN ASISTENCIA_HUELLA A ON P.Id_Persona=P.Id_Persona";
            SqlCommand sql = new SqlCommand(queryReporte, conexion.Conectar());
            sql.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            return data;
        }


    }
}
