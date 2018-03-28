using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCeeLearnAndDo.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Artikel")]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Afbeelding")]
        public string Image { get; set; }

        public ApplicationUser User { get; set; }
    }
}