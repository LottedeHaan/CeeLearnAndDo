using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCeeLearnAndDo.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Vraag")]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        [Display(Name = "Beantwoord")]
        public bool Answered { get; set; }

        public ApplicationUser User { get; set; }
    }
}