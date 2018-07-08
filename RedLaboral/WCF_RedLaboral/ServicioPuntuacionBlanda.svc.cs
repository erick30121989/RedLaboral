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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioPuntuacionBlanda" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioPuntuacionBlanda.svc or ServicioPuntuacionBlanda.svc.cs at the Solution Explorer and start debugging.
    public class ServicioPuntuacionBlanda : IServicioPuntuacionBlanda
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();

        public bool InsertarPuntuacionBlanda(PuntuacionBlandaBE objPuntBlanda)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean blnResultado = false;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "INSERTAR_PUNTUACION_BLANDA";

            cmd.Parameters.Add(new SqlParameter("@IDTRABAJO", SqlDbType.Int));
            cmd.Parameters["@IDTRABAJO"].Value = objPuntBlanda.Id_Trabajo;

            cmd.Parameters.Add(new SqlParameter("@IDHBLANDA", SqlDbType.Int));
            cmd.Parameters["@IDHBLANDA"].Value = objPuntBlanda.Id_H_Blanda;

            cmd.Parameters.Add(new SqlParameter("@PUNTOS", SqlDbType.Int));
            cmd.Parameters["@PUNTOS"].Value = objPuntBlanda.Puntos;

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

        public DataSet ListarPersonasPuntosHBlanda(int puntos, int id_habilidad)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "FILTRAR_PUNTUACION_BLANDA_PUNTOS";

            cmd.Parameters.Add(new SqlParameter("@PUNTOS", SqlDbType.Int));
            cmd.Parameters["@PUNTOS"].Value = puntos;

            cmd.Parameters.Add(new SqlParameter("@IDHBLANDA", SqlDbType.Int));
            cmd.Parameters["@IDHBLANDA"].Value = id_habilidad;
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

        public DataSet ListarPuntuacionBlandoPersona(int id_trabajo)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_PUNTOS_BLANDA_PERSONA";

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

        public DataSet ListarPuntuacionBlandoPersonaDetalles(string dni, int id_habilidad)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DETALLES_PUNTUACION_BLANDA";

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
