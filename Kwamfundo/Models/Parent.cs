using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kwamfundo.Models
{
    public class Parent
    {
        public int parent_id { get; set; }
        public int user_id { get; set; }
        public String address { get; set; }
        public String occupation { get; set; }
    }
}