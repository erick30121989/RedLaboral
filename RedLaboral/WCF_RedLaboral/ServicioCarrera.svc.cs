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
        public int BuscarIdCarrera(string nombre_carrera)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public DataSet ListarRubros()
        {
            throw new NotImplementedException();
        }
    }
}
