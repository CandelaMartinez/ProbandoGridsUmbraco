using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using PruebaUmbracoComposition.Web.ViewModel;
using Umbraco.Web;
using Umbraco.Web.PublishedModels;

namespace PruebaUmbracoComposition.Web.Controllers
{
    public class BlogFolderSurfaceController : SurfaceController
    {
         public ActionResult BlogItemList(int Id)
        {
            var blogFolderNode = Umbraco.Content(Id) as BlogFolder;
            var blogItems = blogFolderNode.Children<BlogItem>();

            var BlogFoldervm = new BlogFolderViewModel();
            BlogFoldervm.BlogFTitle = blogFolderNode.BFtitle;
            BlogFoldervm.Lista = blogItems.OrderBy(i=>i.BlogTitle);

            return PartialView(BlogFoldervm);
        }
    }
}