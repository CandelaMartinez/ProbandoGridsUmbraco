using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.PublishedModels;

namespace PruebaUmbracoComposition.Web.ViewModel
{
    public class BlogFolderViewModel
    {
        public string BlogFTitle {get;set;} 
        public IEnumerable<BlogItem> Lista { get; set; }
    }
}