using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form_OfertaLaboral_PublicarOferta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        try
        {
            ddlPuesto.SelectedIndex = 1;
            ddlJornada.SelectedIndex = 1;
            ddlTipoContrato.SelectedIndex = 1;

            WSOfertaLaboralService.OfertaLaboralServiceClient proxy = new WSOfertaLaboralService.OfertaLaboralServiceClient();
            WSOfertaLaboralService.OfertaLaboral ofertaLaboralCreada = proxy.CrearOfertaLaboral(new WSOfertaLaboralService.OfertaLaboral()
            {
                //ruc = Session["usuario"].ToString(),
                ruc = "12345678901",
                titulo = txtTitulo.Text,
                lugar = txtLugar.Text,
                idPuesto = ddlPuesto.SelectedIndex,
                descrip = txtDescripcion.Text,
                funciones = txtFunciones.Text,
                idJornada = ddlJornada.SelectedIndex,
                idTipoContrato = ddlTipoContrato.SelectedIndex,
                requisitos = txtRequisitos.Text,
                competencias = txtCompetencias.Text,
                estado = "A"
            });

            if (ofertaLaboralCreada != null)
            {
                txtTitulo.Text = "";
                txtLugar.Text = "";
                ddlPuesto.SelectedIndex = 1;
                txtDescripcion.Text = "";
                txtFunciones.Text = "";
                ddlJornada.SelectedIndex = 1;
                ddlTipoContrato.SelectedIndex = 1;
                txtRequisitos.Text = "";
                txtCompetencias.Text = "";


                lblResultado.Text = "Creación exitosa";
            }
            else
            {
                lblResultado.Text = "Error en la creación";
            }
        }
        catch
        {

        }
    }
}