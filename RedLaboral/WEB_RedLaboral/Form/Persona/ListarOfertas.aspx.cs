using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSRedLab;


public partial class Form_OfertaLaboral_ListarOfertas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ServicioRedLabClient client = new ServicioRedLabClient();
            ddlPuesto.DataSource = client.ListaPuesto();
            ddlPuesto.DataValueField = "ID_PUESTO";
            ddlPuesto.DataTextField = "NOMBRE_PUESTO";
            ddlPuesto.DataBind();

            ddlContrato.DataSource = client.ListaContrato();
            ddlContrato.DataValueField = "ID_TIPOCONTRATO";
            ddlContrato.DataTextField = "DESCRIPCION";
            ddlContrato.DataBind();

            client.Close();
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        {
            ServicioRedLabClient client = new ServicioRedLabClient();
            String Puesto = ddlPuesto.SelectedValue;
            String Contrato = ddlContrato.SelectedValue;
            dgvRed.DataSource = client.ListaRedLab(Convert.ToInt64(Puesto), Convert.ToInt64(Contrato));
            dgvRed.DataBind();
            client.Close();

        }
    }
}
