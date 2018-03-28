using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCeeLearnAndDo.Models
{
    public class Reference
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Referentie")]
        public string Content { get; set; }
        [Display(Name = "Link")]
        public string URL { get; set; }
        public DateTime Date { get; set; }

        public ApplicationUser User { get; set; }    }
}