using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SimuladorPlazoFijo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Banco");
            tabla.Columns.Add("Forma de inversión");
            tabla.Columns.Add("Rendimiento");

            tabla.Rows.Add("Banco Provincia", "Anual", "$ " + Convert.ToDecimal(Session["AnualProvincia"]).ToString("N2"));
            tabla.Rows.Add("Banco Provincia", "Trimestral", "$ " + Convert.ToDecimal(Session["TrimestralProvincia"]).ToString("N2"));
            tabla.Rows.Add("Banco Provincia", "Mensual", "$ " + Convert.ToDecimal(Session["MensualProvincia"]).ToString("N2"));

            tabla.Rows.Add("Banco Nación", "Anual", "$ " + Convert.ToDecimal(Session["AnualNacion"]).ToString("N2"));
            tabla.Rows.Add("Banco Nación", "Trimestral", "$ " + Convert.ToDecimal(Session["TrimestralNacion"]).ToString("N2"));
            tabla.Rows.Add("Banco Nación", "Mensual", "$ " + Convert.ToDecimal(Session["MensualNacion"]).ToString("N2"));

            tabla.Rows.Add("Banco Hipotecario", "Anual", "$ " + Convert.ToDecimal(Session["AnualHipotecario"]).ToString("N2"));
            tabla.Rows.Add("Banco Hipotecario", "Trimestral", "$ " + Convert.ToDecimal(Session["TrimestralHipotecario"]).ToString("N2"));
            tabla.Rows.Add("Banco Hipotecario", "Mensual", "$ " + Convert.ToDecimal(Session["MensualHipotecario"]).ToString("N2"));

            GVResultados.DataSource = tabla;
            GVResultados.DataBind();

            decimal mayorRendimiento = Convert.ToDecimal(Session["AnualProvincia"]);
            string mejorBanco = "Banco Provincia";
            string mejorModalidad = "Anual";

            if (Convert.ToDecimal(Session["TrimestralProvincia"]) > mayorRendimiento)
            {
                mayorRendimiento = Convert.ToDecimal(Session["TrimestralProvincia"]);
                mejorModalidad = "Trimestral";
            }

            if (Convert.ToDecimal(Session["MensualProvincia"]) > mayorRendimiento)
            {
                mayorRendimiento = Convert.ToDecimal(Session["MensualProvincia"]);
                mejorModalidad = "Mensual";
            }

            if (Convert.ToDecimal(Session["AnualNacion"]) > mayorRendimiento)
            {
                mayorRendimiento = Convert.ToDecimal(Session["AnualNacion"]);
                mejorBanco = "Banco Nación";
                mejorModalidad = "Anual";
            }

            if (Convert.ToDecimal(Session["TrimestralNacion"]) > mayorRendimiento)
            {
                mayorRendimiento = Convert.ToDecimal(Session["TrimestralNacion"]);
                mejorBanco = "Banco Nación";
                mejorModalidad = "Trimestral";
            }

            if (Convert.ToDecimal(Session["MensualNacion"]) > mayorRendimiento)
            {
                mayorRendimiento = Convert.ToDecimal(Session["MensualNacion"]);
                mejorBanco = "Banco Nación";
                mejorModalidad = "Mensual";
            }

            if (Convert.ToDecimal(Session["AnualHipotecario"]) > mayorRendimiento)
            {
                mayorRendimiento = Convert.ToDecimal(Session["AnualHipotecario"]);
                mejorBanco = "Banco Hipotecario";
                mejorModalidad = "Anual";
            }

            if (Convert.ToDecimal(Session["TrimestralHipotecario"]) > mayorRendimiento)
            {
                mayorRendimiento = Convert.ToDecimal(Session["TrimestralHipotecario"]);
                mejorBanco = "Banco Hipotecario";
                mejorModalidad = "Trimestral";
            }

            if (Convert.ToDecimal(Session["MensualHipotecario"]) > mayorRendimiento)
            {
                mayorRendimiento = Convert.ToDecimal(Session["MensualHipotecario"]);
                mejorBanco = "Banco Hipotecario";
                mejorModalidad = "mensual";
            }

            lblMejorOpcion.Text = "La opción que conviene es " + mejorBanco +
                " con un rendimiento " + mejorModalidad +
                " de $ " + mayorRendimiento.ToString("N2");
        }
    }

}
    
