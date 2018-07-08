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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioEmpresa" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioEmpresa.svc or ServicioEmpresa.svc.cs at the Solution Explorer and start debugging.
    public class ServicioEmpresa : IServicioEmpresa
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();      

        public bool ActualizarContraseña(EmpresaBE objEmpresaBE)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean blnResultado = false;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ACTUALIZAR_CONTRASEÑA_EMPRESA";

            cmd.Parameters.Add(new SqlParameter("@CONTRANUEVA", SqlDbType.VarChar, 10));
            cmd.Parameters["@CONTRANUEVA"].Value = objEmpresaBE.Contraseña;

            cmd.Parameters.Add(new SqlParameter("@RUC", SqlDbType.Char, 11));
            cmd.Parameters["@RUC"].Value = objEmpresaBE.Ruc;

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

        public bool ActualizarEmpresa(EmpresaBE objEmpresaBE)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean blnResultado = false;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ACTUALIZAR_EMPRESA";

            cmd.Parameters.Add(new SqlParameter("@XRUC", SqlDbType.Char, 11));
            cmd.Parameters["@XRUC"].Value = objEmpresaBE.Ruc;

            cmd.Parameters.Add(new SqlParameter("@XRAZON_SOCIAL", SqlDbType.VarChar, 100));
            cmd.Parameters["@XRAZON_SOCIAL"].Value = objEmpresaBE.Razon_social;

            cmd.Parameters.Add(new SqlParameter("@XDIRECCION", SqlDbType.VarChar, 100));
            cmd.Parameters["@XDIRECCION"].Value = objEmpresaBE.Direccion;

            cmd.Parameters.Add(new SqlParameter("@XID_DISTRITO", SqlDbType.Int));
            cmd.Parameters["@XID_DISTRITO"].Value = objEmpresaBE.Id_distrito;

            cmd.Parameters.Add(new SqlParameter("@XEMAIL", SqlDbType.VarChar, 70));
            cmd.Parameters["@XEMAIL"].Value = objEmpresaBE.Correo;

            cmd.Parameters.Add(new SqlParameter("@XPASSWORD1", SqlDbType.VarChar, 10));
            cmd.Parameters["@XPASSWORD1"].Value = objEmpresaBE.Contraseña;

            cmd.Parameters.Add(new SqlParameter("@XESTADO", SqlDbType.Char, 1));
            cmd.Parameters["@XESTADO"].Value = objEmpresaBE.Estado;


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

        public EmpresaBE ConsultarEmpresa(string strCod)
        {
            EmpresaBE objEmpresa = new EmpresaBE();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CONSULTAR_EMPRESA";

            cmd.Parameters.Add(new SqlParameter("@XRUC", SqlDbType.Char, 11));
            cmd.Parameters["@XRUC"].Value = strCod;

            try
            {
                cnx.Open();
                SqlDataReader dtr;
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    //obtenemos los datos

                    objEmpresa.Ruc = dtr[0].ToString();
                    objEmpresa.Razon_social = dtr[1].ToString();
                    objEmpresa.Direccion = dtr[2].ToString();
                    objEmpresa.Id_distrito = Convert.ToInt32(dtr[3].ToString());
                    objEmpresa.Correo = dtr[4].ToString();
                    objEmpresa.Contraseña = dtr[5].ToString();
                    objEmpresa.Estado = dtr[6].ToString();
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
            return objEmpresa;
        }
    }
}
