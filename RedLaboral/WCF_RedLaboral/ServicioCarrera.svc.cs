using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioCarrera" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioCarrera.svc or ServicioCarrera.svc.cs at the Solution Explorer and start debugging.
    public class ServicioCarrera : IServicioCarrera
    {

        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;

        public int BuscarIdCarrera(string nombre_carrera)
        {
            Int32 id_carrera = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Clear();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CONSULTAR_IDCARRERA_X_NOMBRE";

            cmd.Parameters.Add(new SqlParameter("@NOMBRE_CARRERA", SqlDbType.VarChar, 100));
            cmd.Parameters["@NOMBRE_CARRERA"].Value = nombre_carrera;
            cmd.Parameters.Add(new SqlParameter("@ID_CARRERA", SqlDbType.Int));
            cmd.Parameters["@ID_CARRERA"].Direction = ParameterDirection.Output;

            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                return Convert.ToInt32(cmd.Parameters["@ID_CARRERA"].Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ListarCarreras()
        {
            SqlConnection cnx = new SqlConnection();
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = Conexion.strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LISTAR_CARRERA";
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

        public DataSet ListarCarreras2()
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LISTAR_CARRERA_CARRERA";
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

        public DataSet ListarRubros()


        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LISTAR_RUBRO_CARRERA";
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
