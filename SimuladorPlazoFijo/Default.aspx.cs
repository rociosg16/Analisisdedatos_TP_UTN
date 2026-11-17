using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

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
           

            
        }

        // --- FUNCIÓN AUXILIAR: Calcular el promedio de 3 tasas ---
        private decimal CalcularPromedio(decimal t1, decimal t2, decimal t3)
        {
            return (t1 + t2 + t3) / 3m;
        }
    }
}