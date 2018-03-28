using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCeeLearnAndDo.Models
{
    public class Reaction
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Reactie")]
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public ApplicationUser User { get; set; }
    }
}