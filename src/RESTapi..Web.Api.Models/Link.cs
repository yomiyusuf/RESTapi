﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTapi.Web.Api.Models
{
    class Link
    {
        public string Rel { get; set; }
        public string Href { get; set; }
        public string Method { get; set; }
    }
}
