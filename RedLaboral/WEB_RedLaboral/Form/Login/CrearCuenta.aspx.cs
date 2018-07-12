using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form_Login_CrearCuenta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!Page.IsPostBack)
            {
                Panel1_ModalPopupExtender.Show();

                Panel3.Visible = false;
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