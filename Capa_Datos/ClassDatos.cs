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
        public string cadena_conexion = "server=localhostSQLEXPRESS;integrated segurity=true;database=DBTeam";
        private SqlConnection cn;

        public SqlDataAdapter SqlDataAdapter { get; private set; }

        public DataTable D_listar_clientes()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_clientes", cn);
            SqlDataAdapter  = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           
            return dt;
        }

        public DataTable D_buscar_clientes(ClassEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_mantenimiento_clientes(ClassEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.Codigo);
            cmd.Parameters.AddWithValue("@nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@edad", obje.Edad);
            cmd.Parameters.AddWithValue("@telefono", obje.Telefono);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;

        }
    }
}
