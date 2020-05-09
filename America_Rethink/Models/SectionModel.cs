using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace America_Rethink.Models
{
    public class SectionModel
    {

        public string Title { get; set; } = String.Empty;
        public ContentItem[] {get; set;} 
    }


}
