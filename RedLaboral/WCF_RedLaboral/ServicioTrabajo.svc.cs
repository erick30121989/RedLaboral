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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioTrabajo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioTrabajo.svc or ServicioTrabajo.svc.cs at the Solution Explorer and start debugging.
    public class ServicioTrabajo : IServicioTrabajo
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();

        public bool InsertarTrabajo(TrabajoBE objtrabajo)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean blnResultado = false;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INGRESAR_TRABAJO";

            cmd.Parameters.Add(new SqlParameter("@XDNI", SqlDbType.Char, 8));
            cmd.Parameters["@XDNI"].Value = objtrabajo.Dni;

            cmd.Parameters.Add(new SqlParameter("@XRUC", SqlDbType.Char, 11));
            cmd.Parameters["@XRUC"].Value = objtrabajo.Ruc;

            cmd.Parameters.Add(new SqlParameter("@XID_PUESTO", SqlDbType.Int));
            cmd.Parameters["@XID_PUESTO"].Value = objtrabajo.Id_puesto;

            cmd.Parameters.Add(new SqlParameter("@XFECHA_INICIO", SqlDbType.SmallDateTime));
            cmd.Parameters["@XFECHA_INICIO"].Value = objtrabajo.Fecha_inicio;

            cmd.Parameters.Add(new SqlParameter("@XFECHA_FIN", SqlDbType.SmallDateTime));
            cmd.Parameters["@XFECHA_FIN"].Value = objtrabajo.Fecha_fin;

            cmd.Parameters.Add(new SqlParameter("@XESTADO ", SqlDbType.Char, 8));
            cmd.Parameters["@XESTADO "].Value = "A";


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

        public DataSet ListarPersonaExperiencia(int experiencia)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CANTIDAD_EXPERIENCIA";

            cmd.Parameters.Add(new SqlParameter("@EXPERIENCIA", SqlDbType.Int));
            cmd.Parameters["@EXPERIENCIA"].Value = experiencia;
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

        public DataSet ListarPersonaExperienciarRubro(int experiencia, string rubro)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CANTIDAD_EXPERIENCIA_RUBRO";

            cmd.Parameters.Add(new SqlParameter("@EXPERIENCIA", SqlDbType.Int));
            cmd.Parameters["@EXPERIENCIA"].Value = experiencia;

            cmd.Parameters.Add(new SqlParameter("@RUBRO", SqlDbType.VarChar, 100));
            cmd.Parameters["@RUBRO"].Value = rubro;
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

        public DataSet ListarTrabajoporPersona(string strCod)
        {
            DataSet dts = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarTrabajoPersona";
            cmd.Parameters.Add(new SqlParameter("@Dni", SqlDbType.Char, 8));
            cmd.Parameters["@Dni"].Value = strCod;
            try
            {
                ada.SelectCommand = cmd;
                ada.Fill(dts, "TrabajoPersona");
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
            return dts;
        }
    }
}
