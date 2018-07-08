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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioPersona" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioPersona.svc or ServicioPersona.svc.cs at the Solution Explorer and start debugging.
    public class ServicioPersona : IServicioPersona
    {
        SqlConnection cnx = new SqlConnection();
        string strConn = Conexion.strConn;
        SqlCommand cmd = new SqlCommand();

        public bool ActualizarContraseña(PersonaBE objPersona)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean blnResultado = false;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ACTUALIZAR_CONTRASEÑA";

            cmd.Parameters.Add(new SqlParameter("@CONTRANUEVA", SqlDbType.VarChar, 10));
            cmd.Parameters["@CONTRANUEVA"].Value = objPersona.Password;

            cmd.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar, 60));
            cmd.Parameters["@DNI"].Value = objPersona.Dni;

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

        public bool ActualizarPersona(PersonaBE objPersona)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean blnResultado = false;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ACTUALIZAR_PERSONA";

            cmd.Parameters.Add(new SqlParameter("@XDNI", SqlDbType.Char, 8));
            cmd.Parameters["@XDNI"].Value = objPersona.Dni;

            cmd.Parameters.Add(new SqlParameter("@XNOMBRES", SqlDbType.VarChar, 60));
            cmd.Parameters["@XNOMBRES"].Value = objPersona.Nombres;

            cmd.Parameters.Add(new SqlParameter("@XAPELLIDO_PATERNO", SqlDbType.VarChar, 50));
            cmd.Parameters["@XAPELLIDO_PATERNO"].Value = objPersona.ApellidoPaterno;

            cmd.Parameters.Add(new SqlParameter("@XAPELLIDO_MATERNO", SqlDbType.VarChar, 50));
            cmd.Parameters["@XAPELLIDO_MATERNO"].Value = objPersona.ApellidoMaterno;

            cmd.Parameters.Add(new SqlParameter("@XTELEFONO", SqlDbType.Char, 7));
            cmd.Parameters["@XTELEFONO"].Value = objPersona.Telefono;

            cmd.Parameters.Add(new SqlParameter("@XCELULAR", SqlDbType.Char, 9));
            cmd.Parameters["@XCELULAR"].Value = objPersona.Celular;

            cmd.Parameters.Add(new SqlParameter("@XEMAIL", SqlDbType.VarChar, 70));
            cmd.Parameters["@XEMAIL"].Value = objPersona.Email;

            cmd.Parameters.Add(new SqlParameter("@XFECHA_NACIMIENTO", SqlDbType.SmallDateTime));
            cmd.Parameters["@XFECHA_NACIMIENTO"].Value = objPersona.FechaNacimiento;

            cmd.Parameters.Add(new SqlParameter("@XDIRECCION", SqlDbType.VarChar, 200));
            cmd.Parameters["@XDIRECCION"].Value = objPersona.Direccion;

            cmd.Parameters.Add(new SqlParameter("@XID_DISTRITO", SqlDbType.Int));
            cmd.Parameters["@XID_DISTRITO"].Value = objPersona.IdDistrito;

            cmd.Parameters.Add(new SqlParameter("@XPASSWORD1", SqlDbType.VarChar, 10));
            cmd.Parameters["@XPASSWORD1"].Value = objPersona.Password;

            cmd.Parameters.Add(new SqlParameter("@XESTADO", SqlDbType.Char, 1));
            cmd.Parameters["@XESTADO"].Value = objPersona.Estado;

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

        public PersonaBE ConsultarPersona(string strCod)
        {
            PersonaBE objPersona = new PersonaBE();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CONSULTAR_PERSONA";

            cmd.Parameters.Add(new SqlParameter("@XDNI", SqlDbType.Char, 8));
            cmd.Parameters["@XDNI"].Value = strCod;

            try
            {
                cnx.Open();
                SqlDataReader dtr;
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    //obtenemos los datos
                    objPersona.Dni = dtr[0].ToString();
                    objPersona.Nombres = dtr[1].ToString();
                    objPersona.ApellidoPaterno = dtr[2].ToString();
                    objPersona.ApellidoMaterno = dtr[3].ToString();
                    objPersona.Telefono = dtr[4].ToString();
                    objPersona.Celular = dtr[5].ToString();
                    objPersona.Email = dtr[6].ToString();
                    objPersona.FechaNacimiento = Convert.ToDateTime(dtr[7].ToString());
                    objPersona.Direccion = dtr[8].ToString();
                    objPersona.IdDistrito = Convert.ToInt32(dtr[9].ToString());
                    objPersona.Password = dtr[10].ToString();
                    objPersona.Estado = dtr[11].ToString();
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
            return objPersona;
        }

        public Persona_DatosBE DatosPersona(string strCod)
        {
            Persona_DatosBE objPersona = new Persona_DatosBE();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BUSCAR_DATOS_COMPLETOS_PERSONA";

            cmd.Parameters.Add(new SqlParameter("@DNI", SqlDbType.Char, 8));
            cmd.Parameters["@DNI"].Value = strCod;

            try
            {
                cnx.Open();
                SqlDataReader dtr;
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows)
                {
                    dtr.Read();
                    //obtenemos los datos
                    objPersona.Dni = dtr[0].ToString();
                    objPersona.Nombres = dtr[1].ToString();
                    objPersona.Ape_paterno = dtr[2].ToString();
                    objPersona.Ape_materno = dtr[3].ToString();
                    objPersona.Correo = dtr[4].ToString();
                    objPersona.Fecha = Convert.ToDateTime(dtr[5].ToString());
                    objPersona.Telefono = dtr[6].ToString();
                    objPersona.Celular = dtr[7].ToString();
                    objPersona.Direccion = dtr[8].ToString();
                    objPersona.Provincia = dtr[9].ToString();
                    objPersona.Departamento = dtr[10].ToString();
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
            return objPersona;
        }

        public bool EliminarPersona(string strCod)
        {
            throw new NotImplementedException();
        }

        public bool InsertarPersona(PersonaBE objPersona)
        {
            SqlCommand cmd = new SqlCommand();
            Boolean blnResultado = false;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INGRESAR_PERSONA";

            cmd.Parameters.Add(new SqlParameter("@XDNI", SqlDbType.Char, 8));
            cmd.Parameters["@XDNI"].Value = objPersona.Dni;

            cmd.Parameters.Add(new SqlParameter("@XNOMBRES", SqlDbType.VarChar, 60));
            cmd.Parameters["@XNOMBRES"].Value = objPersona.Nombres;

            cmd.Parameters.Add(new SqlParameter("@XAPELLIDO_PATERNO", SqlDbType.VarChar, 50));
            cmd.Parameters["@XAPELLIDO_PATERNO"].Value = objPersona.ApellidoPaterno;

            cmd.Parameters.Add(new SqlParameter("@XAPELLIDO_MATERNO", SqlDbType.VarChar, 50));
            cmd.Parameters["@XAPELLIDO_MATERNO"].Value = objPersona.ApellidoMaterno;

            cmd.Parameters.Add(new SqlParameter("@XTELEFONO", SqlDbType.Char, 7));
            cmd.Parameters["@XTELEFONO"].Value = objPersona.Telefono;

            cmd.Parameters.Add(new SqlParameter("@XCELULAR", SqlDbType.Char, 9));
            cmd.Parameters["@XCELULAR"].Value = objPersona.Celular;

            cmd.Parameters.Add(new SqlParameter("@XEMAIL", SqlDbType.VarChar, 70));
            cmd.Parameters["@XEMAIL"].Value = objPersona.Email;

            cmd.Parameters.Add(new SqlParameter("@XDIRECCION", SqlDbType.VarChar, 200));
            cmd.Parameters["@XDIRECCION"].Value = objPersona.Direccion;

            cmd.Parameters.Add(new SqlParameter("@XFECHA_NACIMIENTO", SqlDbType.SmallDateTime));
            cmd.Parameters["@XFECHA_NACIMIENTO"].Value = objPersona.FechaNacimiento;

            cmd.Parameters.Add(new SqlParameter("@XID_DISTRITO", SqlDbType.Int));
            cmd.Parameters["@XID_DISTRITO"].Value = objPersona.IdDistrito;

            cmd.Parameters.Add(new SqlParameter("@XPASSWORD1", SqlDbType.VarChar, 10));
            cmd.Parameters["@XPASSWORD1"].Value = objPersona.Password;

            cmd.Parameters.Add(new SqlParameter("@XESTADO", SqlDbType.Char, 1));
            cmd.Parameters["@XESTADO"].Value = objPersona.Estado;

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

        public DataSet ListarPersona()
        {
            DataSet dts = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LISTAR_PERSONA";
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

        public string Validacion(string correo, string contraseña)
        {
            string identificador;
            cnx.ConnectionString = strConn;
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Validacion";
            cmd.Parameters.Add(new SqlParameter("@correo", SqlDbType.VarChar, 200));
            cmd.Parameters["@correo"].Value = correo;
            cmd.Parameters.Add(new SqlParameter("@Contra", SqlDbType.VarChar, 10));
            cmd.Parameters["@Contra"].Value = contraseña;
            try
            {
                cnx.Open();
                identificador = Convert.ToString(cmd.ExecuteScalar());
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
            return identificador;
        }
    }
}
