﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAsistencia.CapaModelo;
using SistemaAsistencia.CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAsistencia.CapaDatos
{
    public class ClsUsuarioBD
    {


        

        public DataTable Loguearse_db(string Cedula, string Password)
        {
            ClsConexion conexion = new ClsConexion();
            conexion.Conectar();
            string comando = "SELECT Rol_Usuario, Estado_Usuario FROM USUARIOS WHERE Cedula_Usuario=@Cedula_Usuario AND Password_Usuario=@Password_Usuario";
            SqlCommand sql = new SqlCommand(comando,conexion.Conectar());

            sql.Parameters.AddWithValue("@Cedula_Usuario",Cedula);
            sql.Parameters.AddWithValue("@Password_Usuario",Password);

            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }




        public void AgregarUsuario_db(string Cedula, string Nombre, string Apellido, string Correo, string Celular, string Password, string Rol_Usuario, string Estado, string Direccion_Foto, byte[] Photo)
        {

                ClsConexion conectar = new ClsConexion();
                conectar.Conectar();
                string consultaInsertar = "INSERT INTO USUARIOS (Cedula_Usuario,Nombre_Usuario,Apellido_Usuario,Correo_Usuario,Celular_Usuario,Password_Usuario,Rol_Usuario,Estado_Usuario,Direccion_Imagen,Photo_Usuario)VALUES(@Cedula_Usuario,@Nombre_Usuario,@Apellido_Usuario,@Correo_Usuario,@Celular_Usuario,@Password_Usuario,@Rol_Usuario,@Estado_Usuario,@Direccion_Imagen,@Photo_Usuario)";

                SqlCommand comandoInsertaUsuario = new SqlCommand(consultaInsertar, conectar.Conectar());

                comandoInsertaUsuario.Parameters.AddWithValue("@Cedula_Usuario", Cedula);
                comandoInsertaUsuario.Parameters.AddWithValue("@Nombre_Usuario", Nombre);
                comandoInsertaUsuario.Parameters.AddWithValue("@Apellido_Usuario", Apellido);
                comandoInsertaUsuario.Parameters.AddWithValue("Correo_Usuario", Correo);
                comandoInsertaUsuario.Parameters.AddWithValue("Celular_Usuario", Celular);
                comandoInsertaUsuario.Parameters.AddWithValue("Password_Usuario", Password);
                comandoInsertaUsuario.Parameters.AddWithValue("Rol_Usuario", Rol_Usuario);
                comandoInsertaUsuario.Parameters.AddWithValue("Estado_Usuario", Estado);
                comandoInsertaUsuario.Parameters.AddWithValue("Direccion_Imagen", Direccion_Foto);
                comandoInsertaUsuario.Parameters.AddWithValue("Photo_Usuario", Photo);

                comandoInsertaUsuario.ExecuteNonQuery();
        }




        public void ModificarUsuario_db(string Cedula, string Nombre, string Apellido, string Correo, string Celular, string Password, string Rol_Usuario, string Estado, string Direccion_Foto, byte[] Photo)
        {
            ClsConexion conectar = new ClsConexion();
            conectar.Conectar();
            string consultaModificar = "UPDATE USUARIOS SET Cedula_Usuario=@Cedula_Usuario,Nombre_Usuario=@Nombre_Usuario,Apellido_Usuario=@Apellido_Usuario,Correo_Usuario=@Correo_Usuario,Celular_Usuario=@Celular_Usuario,Password_Usuario=@Password_Usuario,Rol_Usuario=@Rol_Usuario,Estado_Usuario=@Estado_Usuario,Direccion_Imagen=@Direccion_Image,Photo_Usuario=@Photo_Usuario WHERE Cedula_Usuario=@Cedula_Usuario";
            SqlCommand sql = new SqlCommand(consultaModificar,conectar.Conectar());
            sql.Parameters.AddWithValue("@Cedula_Usuario", Cedula);
            sql.Parameters.AddWithValue("@Nombre_Usuario", Nombre);
            sql.Parameters.AddWithValue("@Apellido_Usuario", Apellido);
            sql.Parameters.AddWithValue("Correo_Usuario", Correo);
            sql.Parameters.AddWithValue("Celular_Usuario", Celular);
            sql.Parameters.AddWithValue("Password_Usuario", Password);
            sql.Parameters.AddWithValue("Rol_Usuario", Rol_Usuario);
            sql.Parameters.AddWithValue("Estado_Usuario", Estado);
            sql.Parameters.AddWithValue("Direccion_Imagen", Direccion_Foto);
            sql.Parameters.AddWithValue("Photo_Usuario", Photo);
            sql.ExecuteNonQuery();
        }

    }
}