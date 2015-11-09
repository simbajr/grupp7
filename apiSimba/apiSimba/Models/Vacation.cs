using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiSimba.Models
{
    public class Vacation
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string place { get; set; }
        public string start { get; set; }
        public string end { get; set; }
    }
}