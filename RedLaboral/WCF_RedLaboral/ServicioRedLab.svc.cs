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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioRedLab" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioRedLab.svc o ServicioRedLab.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioRedLab : IServicioRedLab
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();
        
        public String prueba ()
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_RED_LABORAL";
            cmd.Parameters.Add(new SqlParameter("@ID_PUESTO", null));
            cmd.Parameters.Add(new SqlParameter("@ID_TIPOCONTRATO", null));
            //SqlDataAdapter miada =new SqlDataAdapter(cmd);
            //miada.Fill(dts, "Vendedores");
            try
            {
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "RedLab");
            }
            catch (Exception ex)
            {
                return ex.Message;
                //throw ex;
            }
            return "Exito";
        }
        public DataSet ListaRedLab(Int64 vPuesto, Int64 vContrato)
        {
            {
                DataSet dts = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cnx.ConnectionString = strConn;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LISTAR_RED_LABORAL";
                cmd.Parameters.Add(new SqlParameter("@ID_PUESTO", vPuesto));
                cmd.Parameters.Add(new SqlParameter("@ID_TIPOCONTRATO", vContrato));
                //SqlDataAdapter miada =new SqlDataAdapter(cmd);
                //miada.Fill(dts, "Vendedores");
                try
                {
                    SqlDataAdapter miada = new SqlDataAdapter(cmd);
                    miada.Fill(dts, "RedLab");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return dts;
            }
        }

        public DataSet ListaPuesto()
        {
            {
                DataSet dts = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cnx.ConnectionString = strConn;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_LISTAR_PUESTO";
                
                //SqlDataAdapter miada =new SqlDataAdapter(cmd);
                //miada.Fill(dts, "Vendedores");
                try
                {
                    SqlDataAdapter miada = new SqlDataAdapter(cmd);
                    miada.Fill(dts, "Puesto");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return dts;
            }
        }

        public DataSet ListaContrato()
        {
            {
                DataSet dts = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cnx.ConnectionString = strConn;
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Listar_Contrato";
                
                //SqlDataAdapter miada =new SqlDataAdapter(cmd);
                //miada.Fill(dts, "Vendedores");
                try
                {
                    SqlDataAdapter miada = new SqlDataAdapter(cmd);
                    miada.Fill(dts, "Contrato");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return dts;
            }
        }

    }
}
