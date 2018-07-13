using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form_Login_CrearCuenta : System.Web.UI.Page
{
    ProxyDistrito.ServicioDistritoClient servicioDistrito = new ProxyDistrito.ServicioDistritoClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!Page.IsPostBack)
            {
                Panel1_ModalPopupExtender.Show();
                Panel3.Visible = false;


                //COMBO DEPARTAMENTO
                cboDepartamento_P.DataSource = servicioDistrito.ListarDepartamento();
                cboDepartamento_P.DataTextField = "NOMBRE_DEPARTAMENTO";
                cboDepartamento_P.DataValueField = "NOMBRE_DEPARTAMENTO";
                cboDepartamento_P.DataBind();

                //COMBO PROVINCIA
                cboProvincia_P.DataSource = servicioDistrito.ListarProvincia(cboDepartamento_P.Text);
                cboProvincia_P.DataTextField = "NOMBRE_PROVINCIA";
                cboProvincia_P.DataValueField = "NOMBRE_PROVINCIA";
                cboProvincia_P.DataBind();

                ////COMBO DISTRITO
                //cbo_distrito.DataSource = servicioDistrito.ListarDistrito(cbo_provincia.Text);
                //cbo_distrito.DataTextField = "NOMBRE_DISTRITO";
                //cbo_distrito.DataValueField = "ID_DISTRITO";
                //cbo_distrito.DataBind();



            }

          
        }
        catch(Exception ex)
        {

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

        try
        {

        }
        catch (Exception ex)
        {

        }

    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            Panel2.Visible = false;
            Panel3.Visible = true;
        }
        catch (Exception ex)
        {

        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Index.aspx");
        }
        catch (Exception ex)
        {

        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Index.aspx");
        }
        catch (Exception ex)
        {

        }
    }
}