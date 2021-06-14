using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleAspNet.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Le champ designation est requis")]
        public string Designation { get; set; }
        [Required(ErrorMessage ="Le champ Prix est requis")]

        public decimal Prix { get; set; }
        [Required(ErrorMessage = "Le champ Categorie est requis")]

        public int IdCategorie { get; set; }
    }
}