using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kwamfundo.Models
{
    public enum grade {
        [Display(Name = "Grade 8")] grd8,
        [Display(Name = "Grade 9")] grd9,
        [Display(Name = "Grade 10")] grd10,
        [Display(Name = "Grade 11")] grd11,
        [Display(Name = "Grade 12")] grd12,
    }
    public class Learner
    {
        public int learner_id { get; set; }
        public int user_id { get; set; }
        public String id_no { get; set; }
        public grade className { get; set; }

    }
}