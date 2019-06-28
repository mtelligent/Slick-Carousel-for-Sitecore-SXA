// Decompiled with JetBrains decompiler
// Type: Sitecore.XA.Foundation.Grid.Pipelines.RenderPlaceholder.AddPlaceholderWrapper
// Assembly: Sitecore.XA.Foundation.Grid, Version=4.8.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4948D701-0C9E-4F42-ADE8-4773B46FB8C7
// Assembly location: C:\websites\reference.dev.local\bin\Sitecore.XA.Foundation.Grid.dll

using Microsoft.Extensions.DependencyInjection;
using Sitecore.Data.Items;
using Sitecore.DependencyInjection;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Pipelines.Response.RenderPlaceholder;
using Sitecore.Mvc.Presentation;
using Sitecore.XA.Foundation.Grid.Pipelines.RenderPlaceholder;
using Sitecore.XA.Foundation.Grid.Placeholder;
using Sitecore.XA.Foundation.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SF.Feature.SlickCarousel.Pipelines
{ 
    public class DynamicAddPlaceholderWrapper : AddPlaceholderWrapper
    {
        public DynamicAddPlaceholderWrapper(IPresentationContext presentationContext) : base(presentationContext)
        {
        }

        protected override bool MatchPlaceholderName(string excludedPlaceholder, string placeholder)
        {
            if (placeholder.IndexOf(excludedPlaceholder) > -1)
            {
                return true;
            }
            return base.MatchPlaceholderName(excludedPlaceholder, placeholder);
        }
    }
}
