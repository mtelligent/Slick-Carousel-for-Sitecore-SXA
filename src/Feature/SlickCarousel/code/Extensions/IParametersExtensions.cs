using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SF.Feature.SlickCarousel.Extensions
{
    public static class IParametersExtensions
    {
        public static bool IsRenderingParameterChecked(this IParameters parameters, string parameterName)
        {
            return parameters[parameterName] == "1";

        }
    }
}