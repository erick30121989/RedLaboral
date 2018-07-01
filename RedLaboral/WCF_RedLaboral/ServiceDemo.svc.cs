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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDemo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDemo.svc or ServiceDemo.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDemo : IServiceDemo
    {
        public void DoWork()
        {
                
        }

        public string Nombre(string dni)
        {
            string strConn = "server=.;database=RED_LABORAL;user id=sa;password=Dell2017";
            SqlCommand cmd = new SqlCommand();
            SqlConnection cnx = new SqlConnection();         
            Boolean blnResultado = false;
            String cadena = "";
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_demo";
  

            try
            {
                cnx.Open();
                cadena = Convert.ToString(cmd.ExecuteScalar());
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
            return cadena;


            throw new NotImplementedException();
        }
    }
}
