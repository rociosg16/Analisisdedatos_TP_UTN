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
    }
}