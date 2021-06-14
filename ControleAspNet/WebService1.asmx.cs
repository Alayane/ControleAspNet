using ControleAspNet.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace ControleAspNet
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        
        [WebMethod]
        public DataTable ArticlesParCategorie(int id)
        {
            string q = "select *from Article where IdCategorie=@id";
            SqlCommand cmd = new SqlCommand(q);
            cmd.Parameters.AddWithValue("@id", id);
             var dt = DataAccess.getData(cmd);
            dt.TableName = "er";
            return dt;
        }
       
    }
}
