using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SimuladorPlazoFijo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            Validaciones();

            if (!string.IsNullOrEmpty(lblError.Text))
            {
                return;
            }

            CultureInfo cultura = new CultureInfo("es-AR");
            // --- 1. Lectura de texto Banco Provincia ---
            decimal tasaProvincia1 = decimal.Parse(txtProvincia1.Text);
            decimal tasaProvincia2 = decimal.Parse(txtProvincia2.Text);
            decimal tasaProvincia3 = decimal.Parse(txtProvincia3.Text);

            // --- 2. Lectura de texto Banco Nación ---
            decimal tasaNacion1 = decimal.Parse(txtNacion1.Text);
            decimal tasaNacion2 = decimal.Parse(txtNacion2.Text);
            decimal tasaNacion3 = decimal.Parse(txtNacion3.Text);

            // --- 3. Lectura de texto Banco Hipotecario ---
            decimal tasaHipotecario1 = decimal.Parse(txtHipotecario1.Text);
            decimal tasaHipotecario2 = decimal.Parse(txtHipotecario2.Text);
            decimal tasaHipotecario3 = decimal.Parse(txtHipotecario3.Text);

            // --- 4. Cálculo de promedios usando la función  ---
            decimal promedioProvincia = CalcularPromedio(tasaProvincia1, tasaProvincia2, tasaProvincia3);
            decimal promedioNacion = CalcularPromedio(tasaNacion1, tasaNacion2, tasaNacion3);
            decimal promedioHipotecario = CalcularPromedio(tasaHipotecario1, tasaHipotecario2, tasaHipotecario3);

            Session["PromedioProvincia"] = promedioProvincia.ToString("N2");
            Session["PromedioNacion"] = promedioNacion.ToString("N2");
            Session["PromedioHipotecario"] = promedioHipotecario.ToString("N2");

            Response.Redirect("CalculoPromedio.aspx");


        }
        private void Validaciones()
        {

            if (!ValidarCampoDecimal(txtProvincia1, "Tasa 1 - Banco Provincia", lblError)) ;
            if (!ValidarCampoDecimal(txtProvincia2, "Tasa 2 - Banco Provincia", lblError)) ;
            if (!ValidarCampoDecimal(txtProvincia3, "Tasa 3 - Banco Provincia", lblError)) ;

            if (!ValidarCampoDecimal(txtNacion1, "Tasa 1 - Banco Nación", lblError)) ;
            if (!ValidarCampoDecimal(txtNacion2, "Tasa 2 - Banco Nación", lblError)) ;
            if (!ValidarCampoDecimal(txtNacion3, "Tasa 3 - Banco Nación", lblError)) ;

            if (!ValidarCampoDecimal(txtHipotecario1, "Tasa 1 - Banco Hipotecario", lblError)) ;
            if (!ValidarCampoDecimal(txtHipotecario2, "Tasa 2 - Banco Hipotecario", lblError)) ;
            if (!ValidarCampoDecimal(txtHipotecario3, "Tasa 3 - Banco Hipotecario", lblError)) ;

        }

        private bool ValidarCampoDecimal(TextBox txt, string nombreAmigable, Label lblError)
        {
            if (txt.Text.Contains("."))
            {
                lblError.Text = $"⚠️ Usá coma (,) en lugar de punto (.) para los decimales en '{nombreAmigable}'.";
                txt.Focus();
                txt.BackColor = Color.LightPink;
                return false;
            }
                CultureInfo cultura = new CultureInfo("es-AR");

            if (!decimal.TryParse(txt.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, cultura, out _))
            {
                lblError.Text = $"⚠️ El campo '{nombreAmigable}' está vacío o no es un número válido.";
                txt.Focus();
                txt.BackColor = Color.LightPink;
                return false; 
            }

            txt.BackColor = Color.White;
            return true;
        }


        // --- FUNCIÓN AUXILIAR: Calcular el promedio de 3 tasas ---
        private decimal CalcularPromedio(decimal t1, decimal t2, decimal t3)
        {
            return (t1 + t2 + t3) / 3m;
        }
    }
}