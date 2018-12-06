using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace America_Rethink.Models
{
    public class HomeModel
    {
        public bool Logo { get; set; } = true;
        public string Text { get; set; } = "";
        public string Stuff { get; set; } = "";

    }

   
}
