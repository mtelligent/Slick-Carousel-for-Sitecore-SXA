using Sitecore.XA.Feature.Composites.Models;
using Sitecore.XA.Foundation.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SF.Feature.SlickCarousel.Models
{
    public class SlickCarouselModel : CompositeComponentRenderingModel
    {
        public string ContainerClass { get; set; }
        public string DataOptions { get; set; }
    }
}