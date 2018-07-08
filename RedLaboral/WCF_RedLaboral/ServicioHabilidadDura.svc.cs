using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace WCF_RedLaboral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioHabilidadDura" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioHabilidadDura.svc or ServicioHabilidadDura.svc.cs at the Solution Explorer and start debugging.
    public class ServicioHabilidadDura : IServicioHabilidadDura
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();

        public DataSet ListarHabilidadDuraxRubro(string nombre_rubro)
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAR_HABILIDAD_H_DURA_RUBRO";
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

        public bool InsertarPuntuacionDura(PuntuacionDuraBE objPuntBlanda)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarPersonasPuntosHDura(int puntos, int id_habilidad)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarPuntuacionDuraPersona(int id_trabajo)
        {
            throw new NotImplementedException();
        }

        public DataSet ListarPuntuacionDuraPersonaDetalles(string dni, int id_habilidad)
        {
            throw new NotImplementedException();
        }
    }
}
