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
        protected readonly ISlickCarouselItemRepository CarouselItemRepository;

        public SlickCarouselController(ISlickCarouselRepository repository, ISlickCarouselItemRepository itemRepository)
        {
            this.CarouselRepository = repository;
            this.CarouselItemRepository = itemRepository;
        }

        protected override object GetModel()
        {
            return CarouselRepository.GetModel();
        }

        public SlickCarouselItemModel GetCarouselItemModel()
        {
            return CarouselItemRepository.GetModel() as SlickCarouselItemModel;
        }

        public ActionResult CarouselItem()
        {
            var model = GetCarouselItemModel();

            return View(model);
        }

        public override ActionResult Index()
        {
            var model = this.GetModel() as SlickCarouselModel;
            return View(model);
        }
    }
}