using ControleAspNet.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControleAspNet
{
    public partial class WfAJAXconsumation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("arr");
            string q = "select *from Article where IdCategorie=@id";
            SqlCommand cmd = new SqlCommand(q);
            cmd.Parameters.AddWithValue("@id", int.Parse(TextBox1.Text));
            dt = DataAccess.getData(cmd);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }  
    }
}