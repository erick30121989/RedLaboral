using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioHabilidadBlanda" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioHabilidadBlanda.svc or ServicioHabilidadBlanda.svc.cs at the Solution Explorer and start debugging.
    public class ServicioHabilidadBlanda : IServicioHabilidadBlanda
    {

        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();

        public DataSet ListarHabilidadBlanda()
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LISTAR_HBLANDA";
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

        public DataSet ListarHabilidadBlandaxRubro(string nombre_rubro)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_HABILIDAD_H_BLANDA_RUBRO";
            cmd.Parameters.Add(new SqlParameter("@RUBRO", SqlDbType.VarChar, 100));
            cmd.Parameters["@RUBRO"].Value = nombre_rubro;

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

        public DataSet ListarRubroHabilidadBlanda()
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_RUBR_H_BLANDA";
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
    }
}
