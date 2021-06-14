using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ControleAspNet.ServiceReference1;

namespace ControleAspNet
{
    public partial class WebServiceConsumation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecherche_Click(object sender, EventArgs e)
        {
            WebService1SoapClient service = new WebService1SoapClient();
            GridView1.DataSource = service.ArticlesParCategorie(int.Parse(txtId.Text));
            GridView1.DataBind();
        }
    }
}