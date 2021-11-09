using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.PublishedModels;
using PruebaUmbracoComposition.Web.ViewModel;
using Umbraco.Web;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;

namespace PruebaUmbracoComposition.Web.Controllers
{
    public class HeroDesdeHomeSurfaceController : SurfaceController
    {
        
        public ActionResult GetHeroDesdeHome(int Id)
        {
            //obtengo el contenido de la pagina actual por el id que me pasa al llamar al renderAction
            var contentNode = Umbraco.Content(Id);
            //obtengo el root de esa pagina que en este caso es Home
            var home = contentNode.Root() as Home;
            //recupero los campos de Home qu me interesa recuperar
            IPublishedContent heroImage = home.GetProperty("heroBannerHomePropertyImage")?.GetValue() as IPublishedContent;
            String heroTitle = home.GetProperty("heroBannerHomePropertyTitle")?.GetValue() as String;
            String heroSubtitle = home.GetProperty("heroBannerHomePropertySubtitle")?.GetValue() as String;
            var imgUrl = heroImage.Url();

            //instancio mi viewModel que me cree
            //le doy los valores que recupere del contenido publicado a cada una de sus propiedades
            GetHeroDesdeHomeViewModel heroBannerDesdeHomeVM = new GetHeroDesdeHomeViewModel();
            heroBannerDesdeHomeVM.HeroTitleDesdeHome = heroTitle;
            heroBannerDesdeHomeVM.HeroSubtitleDesdeHome = heroSubtitle;
            heroBannerDesdeHomeVM.HeroImageUrlDesdeHome = imgUrl;

            //devuelto la partialView con mismo nombre que metodo ActionResult y paso parametro a la partial con valores llenos
            return PartialView(heroBannerDesdeHomeVM);
        }
    }
}