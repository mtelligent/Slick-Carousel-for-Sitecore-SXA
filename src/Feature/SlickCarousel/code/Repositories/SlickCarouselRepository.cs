using SF.Feature.SlickCarousel.Extensions;
using SF.Feature.SlickCarousel.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SF.Feature.SlickCarousel.Repositories
{
    public class SlickCarouselRepository : ModelRepository, ISlickCarouselRepository
    {
        public override IRenderingModelBase GetModel()
        {
            var model = new SlickCarouselModel();
            FillBaseProperties(model);

            //Exploded changes container class so it's not a carousel.
            if (model.Rendering.Parameters.IsRenderingParameterChecked("Explode"))
            {
                model.ContainerClass = "slick-carousel-editor";
            }
            else
            {
                model.ContainerClass = "slick-carousel";
            }

            var sb = new StringBuilder();
            sb.Append("{");

            var slidesToShow = model.Rendering.Parameters["SlidesToShow"];
            sb.Append(@"""slidesToShow"":").Append(slidesToShow);

            //Prefix each with "," then only add if it varies from Slick Default.

            if (model.Rendering.Parameters.IsRenderingParameterChecked("AutoPlay"))
            {
                sb.Append(@", ""autoPlay"":true");
            }

            if (!model.Rendering.Parameters.IsRenderingParameterChecked("Arrows"))
            {
                sb.Append(@", ""arrows"":false");
            }

            if (!model.Rendering.Parameters.IsRenderingParameterChecked("Infinite"))
            {
                sb.Append(@", ""infinite"":false");
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("Dots"))
            {
                sb.Append(@", ""dots"":true");
            }

            var autoplaySpeed = model.Rendering.Parameters["AutoplaySpeed"];
            if (!string.IsNullOrEmpty(autoplaySpeed) && autoplaySpeed != "3000")
            {
                sb.Append(@", ""autoplaySpeed"":").Append(autoplaySpeed);
            }

            if (!model.Rendering.Parameters.IsRenderingParameterChecked("Draggable"))
            {
                sb.Append(@", ""draggable"":false");
            }

            var initialSlide = model.Rendering.Parameters["InitialSlide"];
            if (!string.IsNullOrEmpty(initialSlide) && initialSlide != "0")
            {
                sb.Append(@", ""initialSlide"":").Append(initialSlide);
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("MobileFirst"))
            {
                sb.Append(@", ""mobileFirst"":true");
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("PauseOnDotsHover"))
            {
                sb.Append(@", ""pauseOnDotsHover"":true");
            }

            if (!model.Rendering.Parameters.IsRenderingParameterChecked("PauseOnFocus"))
            {
                sb.Append(@", ""pauseOnFocus"":false");
            }

            if (!model.Rendering.Parameters.IsRenderingParameterChecked("PauseOnHover"))
            {
                sb.Append(@", ""pauseOnHover"":false");
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("Fade"))
            {
                sb.Append(@", ""fade"":true");
            }

            var speed = model.Rendering.Parameters["Speed"];
            if (!string.IsNullOrEmpty(speed) && speed != "300")
            {
                sb.Append(@", ""speed"":").Append(speed);
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("SwipeToSlide"))
            {
                sb.Append(@", ""swipeToSlide"":true");
            }

            if (!model.Rendering.Parameters.IsRenderingParameterChecked("TouchMove"))
            {
                sb.Append(@", ""touchMove"":false");
            }

            var touchThreshold = model.Rendering.Parameters["TouchThreshold"];
            if (!string.IsNullOrEmpty(touchThreshold) && touchThreshold != "5")
            {
                sb.Append(@", ""touchThreshold"":").Append(touchThreshold);
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("Vertical"))
            {
                sb.Append(@", ""vertical"":true");
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("VerticalSwiping"))
            {
                sb.Append(@", ""verticalSwiping"":true");
            }

            var easing = model.Rendering.Parameters["Easing"];
            if (!string.IsNullOrEmpty(easing) && easing != "ease")
            {
                sb.Append(@", ""cssEase"":""").Append(easing).Append(@"""");
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("AdaptiveHeight"))
            {
                sb.Append(@", ""adaptiveHeight"":true");
            }

            if (model.Rendering.Parameters.IsRenderingParameterChecked("CenterMode"))
            {
                sb.Append(@", ""centerMode"":true");
            }

            var centerPadding = model.Rendering.Parameters["CenterPadding"];
            if (!string.IsNullOrEmpty(centerPadding) && centerPadding != "50px")
            {
                sb.Append(@", ""centerPadding"":").Append(easing);
            }

            var rows = model.Rendering.Parameters["Rows"];
            if (!string.IsNullOrEmpty(rows) && rows != "1")
            {
                sb.Append(@", ""rows"":").Append(rows);
            }

            var slidesPerRow = model.Rendering.Parameters["SlidesPerRow"];
            if (!string.IsNullOrEmpty(slidesPerRow) && slidesPerRow != "1")
            {
                sb.Append(@", ""slidesPerRow"":").Append(slidesPerRow);
            }

            var slidesToScroll = model.Rendering.Parameters["SlidesToScroll"];
            if (!string.IsNullOrEmpty(slidesToScroll) && slidesToScroll != "1")
            {
                sb.Append(@", ""slidesToScroll"":").Append(slidesToScroll);
            }

            var zIndex = model.Rendering.Parameters["Zindex"];
            if (!string.IsNullOrEmpty(zIndex) && zIndex != "1000")
            {
                sb.Append(@", ""zIndex"":").Append(zIndex);
            }

            var additionalOptions = model.Rendering.Parameters["additionalOptions"];
            if (!string.IsNullOrEmpty(additionalOptions))
            {
                sb.Append(@",").Append(additionalOptions);
            }

            sb.Append("}");

            model.DataOptions = sb.ToString();

            return model;
        }
    }
}