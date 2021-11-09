using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;
using PruebaUmbracoComposition.Web.ViewModel;
using Umbraco.Web;
using Umbraco.Core.Models;

namespace PruebaUmbracoComposition.Web.Controllers
{
    public class HeroBannerSurfaceController : SurfaceController
    {
        
        public ActionResult HeroBannerImage(int Id)
        {
            //primero probe de poner as Home pero esta partial solo me servia para recuperar la imagen de la composition que esta en Home
            //var homeNode = Umbraco.Content(Id) as Home;

            //luego probe no poner ningun as y me resulto ok, por ahora.....
            var node = Umbraco.Content(Id);

           
            //var imageHeroBanner = homeNode.HeroBannerIimage;
            //var titleHeroBanner = homeNode.HeroBannerTitle;
            //var subtitleHeroBanner = homeNode.HeroBannerSubtitle;

            var imageHeroBanner = node.Value<MediaWithCrops>("HeroBannerIimage");
            var titleHeroBanner = node.Value<string>("HeroBannerTitle");
            var subtitleHeroBanner = node.Value<string>("HeroBannerSubtitle");

            var heroBannerVm = new HeroBannerViewModel();

            //OJO: no me funcionan las comprobaciones String
            if(String.IsNullOrEmpty(titleHeroBanner))
            {
                heroBannerVm.HeroTitle = "Default Title";
              
            }
            else
            {
                heroBannerVm.HeroTitle = titleHeroBanner;
            }
           

            if(!String.IsNullOrEmpty(subtitleHeroBanner) )
            {
                heroBannerVm.HeroSubtitle = subtitleHeroBanner;
            }
            else
            {
                heroBannerVm.HeroSubtitle = "Default Subtitle";
            }
           

            if (imageHeroBanner != null)
            {
                heroBannerVm.HeroImageUrl = imageHeroBanner.Url();
            }
            else
            {
                heroBannerVm.HeroImageUrl = "/Images/pexels-burst-374906.jpg";
            }


            return PartialView(heroBannerVm);
        }
    }
}