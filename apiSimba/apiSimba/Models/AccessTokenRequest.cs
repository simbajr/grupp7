﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiSimba.Models
{
    public class AccessTokenRequest
    {
        public string grant_type { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}