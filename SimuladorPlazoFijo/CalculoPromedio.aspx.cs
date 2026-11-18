using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimuladorPlazoFijo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["PromedioProvincia"] != null)
                {
                    lblPromedioProvincia.Text =  Session["PromedioProvincia"].ToString();
                    lblPromedioNacion.Text = Session["PromedioNacion"].ToString();
                    lblPromedioHipotecario.Text =  Session["PromedioHipotecario"].ToString();
                }
            }
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            decimal promedioProvincia = Convert.ToDecimal(Session["PromedioProvincia"]);
            decimal promedioNacion = Convert.ToDecimal(Session["PromedioNacion"]);
            decimal promedioHipotecario = Convert.ToDecimal(Session["PromedioHipotecario"]);

            decimal capitalInicial = 850000m;

            decimal rendimientoAnualProvincia = capitalInicial * (promedioProvincia / 100m);
            decimal rendimientoAnualNacion = capitalInicial * (promedioNacion / 100m);
            decimal rendimientoAnualHipotecario = capitalInicial * (promedioHipotecario / 100m);

            decimal capitalTrimestralProvincia = capitalInicial;
            decimal capitalTrimestralNacion = capitalInicial;
            decimal capitalTrimestralHipotecario = capitalInicial;

            for (int i = 0; i < 4; i++)
            {
                capitalTrimestralProvincia += capitalTrimestralProvincia * ((promedioProvincia / 100m) / 4m);
                capitalTrimestralNacion += capitalTrimestralNacion * ((promedioNacion / 100m) / 4m);
                capitalTrimestralHipotecario += capitalTrimestralHipotecario * ((promedioHipotecario / 100m) / 4m);
            }

            decimal rendimientoTrimestralProvincia = capitalTrimestralProvincia - capitalInicial;
            decimal rendimientoTrimestralNacion = capitalTrimestralNacion - capitalInicial;
            decimal rendimientoTrimestralHipotecario = capitalTrimestralHipotecario - capitalInicial;

            decimal capitalMensualProvincia = capitalInicial;
            decimal capitalMensualNacion = capitalInicial;
            decimal capitalMensualHipotecario = capitalInicial;

            for (int i = 0; i < 12; i++)
            {
                capitalMensualProvincia += capitalMensualProvincia * ((promedioProvincia / 100m) / 12m);
                capitalMensualNacion += capitalMensualNacion * ((promedioNacion / 100m) / 12m);
                capitalMensualHipotecario += capitalMensualHipotecario * ((promedioHipotecario / 100m) / 12m);
            }

            decimal rendimientoMensualProvincia = capitalMensualProvincia - capitalInicial;
            decimal rendimientoMensualNacion = capitalMensualNacion - capitalInicial;
            decimal rendimientoMensualHipotecario = capitalMensualHipotecario - capitalInicial;

            Session["AnualProvincia"] = rendimientoAnualProvincia;
            Session["AnualNacion"] = rendimientoAnualNacion;
            Session["AnualHipotecario"] = rendimientoAnualHipotecario;
            Session["TrimestralProvincia"] = rendimientoTrimestralProvincia;
            Session["TrimestralNacion"] = rendimientoTrimestralNacion;
            Session["TrimestralHipotecario"] = rendimientoTrimestralHipotecario;
            Session["MensualProvincia"] = rendimientoMensualProvincia;
            Session["MensualNacion"] = rendimientoMensualNacion;
            Session["MensualHipotecario"] = rendimientoMensualHipotecario;


            Response.Redirect("MejorInversion.aspx");
        }
    }
}