using SF.Feature.SlickCarousel.Models;
using SF.Feature.SlickCarousel.Repositories;
using SF.Feature.SlickCarousel.Extensions;
using Sitecore.XA.Foundation.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SF.Feature.SlickCarousel.Controllers
{
    public class SlickCarouselController : StandardController
    {
        protected readonly ISlickCarouselRepository CarouselRepository;

        public SlickCarouselController(ISlickCarouselRepository repository)
        {
            this.CarouselRepository = repository;
        }

        protected override object GetModel()
        {
            return CarouselRepository.GetModel();
        }

        public override ActionResult Index()
        {
            var model = this.GetModel() as SlickCarouselModel;
            return View(model);
        }
    }
}