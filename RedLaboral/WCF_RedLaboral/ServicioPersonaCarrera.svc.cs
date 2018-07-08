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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioPersonaCarrera" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioPersonaCarrera.svc or ServicioPersonaCarrera.svc.cs at the Solution Explorer and start debugging.
    public class ServicioPersonaCarrera : IServicioPersonaCarrera
    {

        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();

        public DataSet ListarCarreraporPersona(string dni)
        {
            DataSet dts = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarCarreraPersona";
            cmd.Parameters.Add(new SqlParameter("@Dni", SqlDbType.Char, 8));
            cmd.Parameters["@Dni"].Value = dni;
            try
            {
                ada.SelectCommand = cmd;
                ada.Fill(dts, "CarreraPersona");
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

        public DataSet ListarPersonaCarrera(int id_carrera)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTA_PERSONA_CARRERA";

            cmd.Parameters.Add(new SqlParameter("@ID_CARRERA", SqlDbType.Int));
            cmd.Parameters["@ID_CARRERA"].Value = id_carrera;
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

        public PersonaCarreraDetalle ListarPersonaCarreraDetalles(string dni, int nombre_carrera)
        {
            PersonaCarreraDetalle objPersonaCarreraDetalle = new PersonaCarreraDetalle();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CONSULTAR_PERSONA_CARRERA_DETALLES";

            cmd.Parameters.Add(new SqlParameter("@XDNI", SqlDbType.Char, 8));
            cmd.Parameters["@XDNI"].Value = dni;
            cmd.Parameters.Add(new SqlParameter("@XNOMBRE", SqlDbType.Int));
            cmd.Parameters["@XNOMBRE"].Value = nombre_carrera;
            try
            {
                cnx.Open();
                SqlDataReader dtr;
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    //obtenemos los datos
                    objPersonaCarreraDetalle.Dni = dtr[0].ToString();
                    objPersonaCarreraDetalle.Datos = dtr[1].ToString();
                    objPersonaCarreraDetalle.Email = dtr[2].ToString();
                    objPersonaCarreraDetalle.Telefono = dtr[3].ToString();
                    objPersonaCarreraDetalle.Celular = dtr[4].ToString();
                    objPersonaCarreraDetalle.Direccion = dtr[5].ToString();
                    objPersonaCarreraDetalle.Distrito = dtr[6].ToString();
                    objPersonaCarreraDetalle.Provincia = dtr[7].ToString();
                    objPersonaCarreraDetalle.Departamento = dtr[8].ToString();
                    objPersonaCarreraDetalle.Carrera = dtr[9].ToString();
                    objPersonaCarreraDetalle.Institucion = dtr[10].ToString();
                    objPersonaCarreraDetalle.Promedio = Convert.ToInt32(dtr[11].ToString());
                    objPersonaCarreraDetalle.Puesto_final = Convert.ToInt32(dtr[12].ToString());
                    objPersonaCarreraDetalle.F_inicio = Convert.ToDateTime(dtr[13].ToString());
                    objPersonaCarreraDetalle.F_fin = Convert.ToDateTime(dtr[14].ToString());


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            return objPersonaCarreraDetalle;
        }

        public DataSet ListarPersonaPromedio(int nota)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_PERSONA_PROMEDIO";

            cmd.Parameters.Add(new SqlParameter("@NOTA", SqlDbType.Int));
            cmd.Parameters["@NOTA"].Value = nota;
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

        public DataSet ListarPersonarRubroCarrera(string rubro)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_PERSONA_RUBRO_CARRERA";

            cmd.Parameters.Add(new SqlParameter("@NOMBBRE_RUBRO", SqlDbType.VarChar, 100));
            cmd.Parameters["@NOMBBRE_RUBRO"].Value = rubro;
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
