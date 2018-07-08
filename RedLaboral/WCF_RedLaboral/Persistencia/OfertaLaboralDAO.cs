using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCF_RedLaboral.Dominio;

namespace WCF_RedLaboral.Persistencia
{
    public class OfertaLaboralDAO
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;

        public OfertaLaboral Crear(OfertaLaboral ofertaLaboralACrear)
        {
            OfertaLaboral ofertaLaboralCreada = null;
            int idOfertaLaboral;

            string sql = "SP_INGRESAR_OFERTA_LABORAL";

            using (SqlConnection conexion = new SqlConnection(strConn))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Add(new SqlParameter("@XRUC", ofertaLaboralACrear.ruc));
                    comando.Parameters.Add(new SqlParameter("@XTITULO", ofertaLaboralACrear.titulo));
                    comando.Parameters.Add(new SqlParameter("@XLUGAR", ofertaLaboralACrear.lugar));
                    comando.Parameters.Add(new SqlParameter("@XID_PUESTO", ofertaLaboralACrear.idPuesto));
                    comando.Parameters.Add(new SqlParameter("@XDESCRIP", ofertaLaboralACrear.descrip));
                    comando.Parameters.Add(new SqlParameter("@XFUNCIONES", ofertaLaboralACrear.funciones));
                    comando.Parameters.Add(new SqlParameter("@XID_JORNADA", ofertaLaboralACrear.idJornada));
                    comando.Parameters.Add(new SqlParameter("@XID_TIPOCONTRATO", ofertaLaboralACrear.idTipoContrato));
                    comando.Parameters.Add(new SqlParameter("@XREQUISITOS", ofertaLaboralACrear.requisitos));
                    comando.Parameters.Add(new SqlParameter("@XCOMPETENCIAS", ofertaLaboralACrear.competencias));
                    comando.Parameters.Add(new SqlParameter("@XESTADO", ofertaLaboralACrear.estado));

                    SqlParameter outPutVal = new SqlParameter("@XLASTID", SqlDbType.Int);
                    outPutVal.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(outPutVal);

                    comando.ExecuteNonQuery();

                    idOfertaLaboral = Convert.ToInt32(outPutVal.Value);
                }
            }
            ofertaLaboralCreada = Obtener(idOfertaLaboral);
            return ofertaLaboralCreada;
        }

        public OfertaLaboral Obtener(int idOfertaLaboral)
        {
            OfertaLaboral ofertaLaboralEncontrada = null;
            string sql = "SP_CONSULTAR_OFERTA_LABORAL";
            using (SqlConnection conexion = new SqlConnection(strConn))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@XID_OFERTA", idOfertaLaboral);
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            ofertaLaboralEncontrada = new OfertaLaboral()
                            {
                                idOfertaLaboral= (int)resultado["ID_OFERTA"],
                                ruc = (string)resultado["RUC"],
                                titulo = (string)resultado["TITULO"],
                                lugar = (string)resultado["LUGAR"],
                                idPuesto = (int)resultado["ID_PUESTO"],
                                descrip = (string)resultado["DESCRIP"],
                                funciones = (string)resultado["FUNCIONES"],
                                idJornada = (int)resultado["ID_JORNADA"],
                                idTipoContrato = (int)resultado["ID_TIPOCONTRATO"],
                                requisitos = (string)resultado["REQUISITOS"],
                                competencias = (string)resultado["COMPETENCIAS"],
                                estado = (string)resultado["ESTADO"]
                            };
                        }
                    }
                }
            }
            return ofertaLaboralEncontrada;
        }
    }
}