using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioDistrito" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioDistrito.svc or ServicioDistrito.svc.cs at the Solution Explorer and start debugging.
    public class ServicioDistrito : IServicioDistrito
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;

        public DataSet ListarDepartamento()
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LISTAR_POR_DEPARTAMENTO";
            //SqlDataAdapter miada =new SqlDataAdapter(cmd);
            //miada.Fill(dts, "Vendedores");
            try
            {
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Distrito");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dts;
        }

        public DataSet ListarDistrito(string provincia)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LISTAR_POR_DISTRITO";

            cmd.Parameters.Add(new SqlParameter("@XProvincia", SqlDbType.VarChar, 100));
            cmd.Parameters["@XProvincia"].Value = provincia;
            //SqlDataAdapter miada =new SqlDataAdapter(cmd);
            //miada.Fill(dts, "Vendedores");
            try
            {
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Distrito");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dts;
        }

        public DataSet ListarProvincia(string departamento)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LISTAR_POR_PROVINCIA";

            cmd.Parameters.Add(new SqlParameter("@XDepartamento", SqlDbType.VarChar, 100));
            cmd.Parameters["@XDepartamento"].Value = departamento;
            //SqlDataAdapter miada =new SqlDataAdapter(cmd);
            //miada.Fill(dts, "Vendedores");
            try
            {
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Distrito");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dts;
        }

        public string ObtenerDepartamento(int IdDistrito)
        {
            String Departamento;
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_OBTENER_DEPARTAMENTO";
            cmd.Parameters.Add(new SqlParameter("@IDDISTRITO", SqlDbType.Int));
            cmd.Parameters["@IDDISTRITO"].Value = IdDistrito;
            try
            {
                cnx.Open();
                Departamento = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return Departamento;
        }

        public string ObtenerProvincia(int IdDistrito)
        {
            String Provincia;
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_OBTENER_PROVINCIA";
            cmd.Parameters.Add(new SqlParameter("@IDDISTRITO", SqlDbType.Int));
            cmd.Parameters["@IDDISTRITO"].Value = IdDistrito;
            try
            {
                cnx.Open();
                Provincia = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd.Parameters.Clear();
            }
            return Provincia;
        }
    }
}
