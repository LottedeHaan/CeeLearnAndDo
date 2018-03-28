using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCeeLearnAndDo.Models
{
    public class Media
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Display(Name = "Afbeelding pad")]
        public string Path { get; set; }
        public DateTime Date { get; set; }
    }
}