using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class ClassDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_estudiantes()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_estudiantes", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public DataTable D_buscar_estudiantes(ClassEntidad Obje) 
        {

            SqlCommand cmd = new SqlCommand("sp_buscar_estudiantes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", Obje.Nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string D_mantenimiento_estudiantes(ClassEntidad Obje) 
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_estudiantes",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", Obje.Codigo);
            cmd.Parameters.AddWithValue("@Pais", Obje.Pais);
            cmd.Parameters.AddWithValue("@Institucion", Obje.Institucion);
            cmd.Parameters.AddWithValue("@Nombre", Obje.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Obje.Apellido);
            cmd.Parameters.AddWithValue("@FechaNacimiento", Obje.FechaNacimiento);
            cmd.Parameters.AddWithValue("@Sexo", Obje.Sexo);
            cmd.Parameters.AddWithValue("@Email", Obje.Email);
            cmd.Parameters.AddWithValue("@Carrera", Obje.Carrera);
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar,50).Value = Obje.Accion;
            cmd.Parameters["@Accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close(); 
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@Accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
}
