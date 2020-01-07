using Daw_Proiect.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Daw_Proiect.Models
{
    public class Article
    {   [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public float Pret { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Range(1,5, ErrorMessage= "Ratingul trebuie sa fie intre 1 si 5 stele")][Required]
        public float Rating { get; set; }
        [Required]
        public string Review { get; set; }
        public int Approved { get; set; }
        public string UserId { get; set; }
        public virtual Category Category { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}