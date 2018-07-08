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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioPuntuacionDura" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioPuntuacionDura.svc or ServicioPuntuacionDura.svc.cs at the Solution Explorer and start debugging.
    public class ServicioPuntuacionDura : IServicioPuntuacionDura
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();

        public bool InsertarPuntuacionDura(PuntuacionDuraBE objPuntBlanda)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean blnResultado = false;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INGRESAR_PUNTUACIONDURA";

            cmd.Parameters.Add(new SqlParameter("@XID_TRABAJO", SqlDbType.Int));
            cmd.Parameters["@XID_TRABAJO"].Value = objPuntBlanda.Id_Trabajo;

            cmd.Parameters.Add(new SqlParameter("@XID_H_HDURA", SqlDbType.Int));
            cmd.Parameters["@XID_H_HDURA"].Value = objPuntBlanda.Id_H_Dura;

            cmd.Parameters.Add(new SqlParameter("@XPUNTOS", SqlDbType.Int));
            cmd.Parameters["@XPUNTOS"].Value = objPuntBlanda.Puntos;

            try
            {
                cnx.Open();
                cmd.ExecuteNonQuery();
                blnResultado = true;
            }
            catch (Exception ex)
            {
                blnResultado = false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            return blnResultado;
        }

        public DataSet ListarPersonasPuntosHDura(int puntos, int id_habilidad)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "FILTRAR_PUNTUACION_DURA_PUNTOS";

            cmd.Parameters.Add(new SqlParameter("@PUNTOS", SqlDbType.Int));
            cmd.Parameters["@PUNTOS"].Value = puntos;

            cmd.Parameters.Add(new SqlParameter("@IDHDURA", SqlDbType.Int));
            cmd.Parameters["@IDHDURA"].Value = id_habilidad;
            //SqlDataAdapter miada =new SqlDataAdapter(cmd);
            //miada.Fill(dts, "Vendedores");
            try
            {
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Persona");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dts;
        }

        public DataSet ListarPuntuacionDuraPersona(int id_trabajo)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_PUNTOS_DURA_PERSONA";

            cmd.Parameters.Add(new SqlParameter("@ID_TRABAJO", SqlDbType.Int));
            cmd.Parameters["@ID_TRABAJO"].Value = id_trabajo;

            //SqlDataAdapter miada =new SqlDataAdapter(cmd);
            //miada.Fill(dts, "Vendedores");
            try
            {
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Persona");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dts;
        }

        public DataSet ListarPuntuacionDuraPersonaDetalles(string dni, int id_habilidad)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DETALLES_PUNTUACION_DURA";

            cmd.Parameters.Add(new SqlParameter("@DNI", SqlDbType.Char, 8));
            cmd.Parameters["@DNI"].Value = dni;
            cmd.Parameters.Add(new SqlParameter("@ID_HABILIDAD", SqlDbType.Int));
            cmd.Parameters["@ID_HABILIDAD"].Value = id_habilidad;

            //SqlDataAdapter miada =new SqlDataAdapter(cmd);
            //miada.Fill(dts, "Vendedores");
            try
            {
                SqlDataAdapter miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Persona");

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dts;
        }
    }
}
