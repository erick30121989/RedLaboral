using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form_Login_Index : System.Web.UI.Page
{
    ProxyPersona.ServicioPersonaClient servicioPersona = new ProxyPersona.ServicioPersonaClient();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_ingresar_Click1(object sender, EventArgs e)
    {
        try
        {
            string correo = txt_correo.Text.Trim();
            string contrasena = txt_contrasena.Text.Trim();
            string usuario;
            string mensaje = "";

            //Validando que ingrese los datos correctos
            if (correo.Length == 0 || contrasena.Length == 0)
            {
                mensaje = "INGRESE USUARIO Y CONTRASEÑA";
                throw new Exception(mensaje);
                //sfsdfassd
                //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=''JavaScript''>alert('" + "INGRESE USUARIO Y CONTRASEÑA" + "')</SCRIPT>");
            }

            //Validando que el correo tenga el formato correcto
            bool validaCorreo = validarCorreo(correo);

            if (!validaCorreo)
            {
                mensaje = "FORMATO DE CORREO INVALIDO";
                throw new Exception(mensaje);
            }


            usuario = servicioPersona.Validacion(correo, contrasena);

            if (usuario == string.Empty)
            {
                mensaje = "USUARIO NO EXISTE O CLAVE INCORRECTA";
                throw new Exception(mensaje);
                //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=''JavaScript''>alert('" + "USUARIO NO EXISTE O CLAVE INCORRECTA" + "')</SCRIPT>");
            }
            else
            {
                mensaje = "INGRESO EXITOSO";
                Session["usuario"] = usuario.ToString();
                throw new Exception(Session["usuario"].ToString());
                //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=''JavaScript''>alert('" + "INGRESO EXITOSO" + "')</SCRIPT>");
            }




        }
        catch(Exception ex)
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=''JavaScript''>alert('" + ex.Message + "')</SCRIPT>");
        }
    }

    protected void btn_registrarse_Click(object sender, EventArgs e)
    {

    }

    protected void btn_registrarse_Click1(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("CrearCuenta.aspx");
        }
        catch (Exception ex)
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=''JavaScript''>alert('" + ex.Message + "')</SCRIPT>");
        }
    }

    //Metodo de validacion de correo
    bool validarCorreo(string correo)
    {
        try
        {
            new MailAddress(correo);
            return true;
        }
        catch(FormatException)
        {
            return false;
        }
        
    }

}