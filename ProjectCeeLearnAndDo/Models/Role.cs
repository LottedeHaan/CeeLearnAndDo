using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectCeeLearnAndDo.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Display(Name = "Rol")]
        public string Rolename { get; set; }
    }
}