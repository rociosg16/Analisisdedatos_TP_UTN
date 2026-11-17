using System;
using System.Collections.Generic;
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
            

        }

        protected void btnCalcualar_Click(object sender, EventArgs e)
        {
            decimal tasaProvincia1 = decimal.Parse(txtProvincia1.Text);
            decimal tasaProvincia2 = decimal.Parse(txtProvincia2.Text);
            decimal tasaProvincia3 = decimal.Parse(txtProvincia3.Text);

            decimal tasaNacion1 = decimal.Parse(txtNacion1.Text);
            decimal tasaNacion2 = decimal.Parse(txtNacion2.Text);
            decimal tasaNacion3 = decimal.Parse(txtNacion3.Text);

            decimal tasaHipotecario1 = decimal.Parse(txtHipotecario1.Text);
            decimal tasaHipotecario2 = decimal.Parse(txtHipotecario2.Text);
            decimal tasaHipotecario3 = decimal.Parse(txtHipotecario3.Text);

        }
    }
}