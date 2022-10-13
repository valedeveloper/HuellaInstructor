using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAsistencia.CapaModelo
{
    public class ClsConexion
    {

        public SqlConnection Conectar()
        {
            //Se usa Sql Conecction para hacer la conexiòn a la BD
            //Por paràmetro entra la cadena de conexiòn
            SqlConnection conexion = new SqlConnection("Data Source = localhost; Initial Catalog = Sistema de Asistencia; Integrated Security = True");
            conexion.Open();
            return conexion;
        }



       
    }
}
