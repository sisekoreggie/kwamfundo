using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kwamfundo.Models
{
    public class User
    {
        public int user_id { get; set; }

        [Display(Name = "Name")]
        public String name { get; set; }

        [Display(Name = "Surname")]
        public String surname { get; set; }

        [Display(Name = "Email")]
        public String email { get; set; }

        [Display(Name = "Password")]
        public String password { get; set; }

        [Display(Name = "Cellphone Number")]
        public String cell { get; set; }
    }
}