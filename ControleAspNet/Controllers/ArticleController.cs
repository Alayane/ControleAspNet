using ControleAspNet.DAL;
using ControleAspNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleAspNet.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            List<Article> articles = new List<Article>();
            string q = "select *from Article";
            SqlCommand cmd = new SqlCommand(q);
            DataTable dt = DataAccess.getData(cmd);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    Article a = new Article();
                    a.Id = int.Parse(r[0].ToString());
                    a.Designation = r[1].ToString();
                    a.Prix =decimal.Parse( r[2].ToString());
                    a.IdCategorie =int.Parse(r[3].ToString());
                    articles.Add(a);
                }
            }


            return View(articles);
        }

        public ActionResult Create()
        {
            List<Categorie> categories = new List<Categorie>();
            string q = "select *from [dbo].[Categorie]";
            SqlCommand cmd = new SqlCommand(q);
            DataTable dt = DataAccess.getData(cmd);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    categories.Add(new Categorie {Id=int.Parse(r[0].ToString()),NomCat=r[1].ToString() });
                }
            }
            SelectList sl = new SelectList(categories, "Id", "NomCat");
            ViewBag.Categories = sl;
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Article article)
        {
            string q = "Insert into Article values(@des,@prix,@id)";
            SqlCommand cmd = new SqlCommand(q);
            cmd.Parameters.AddWithValue("@des", article.Designation);
            cmd.Parameters.AddWithValue("@prix", article.Prix);
            cmd.Parameters.AddWithValue("@id", article.IdCategorie);
            DataAccess.setData(cmd);
            return RedirectToAction("Index");
        }
    }
}