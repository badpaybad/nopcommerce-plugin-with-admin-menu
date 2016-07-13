using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.BadPayBad.Core.Data;
using Nop.Plugin.BadPayBad.Core.Infrastructure;
using Nop.Plugin.BadPayBad.WidgetIframe.Data;
using Nop.Plugin.BadPayBad.WidgetIframe.Domain;
using Nop.Plugin.BadPayBad.WidgetIframe.Services;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.BadPayBad.WidgetIframe.Infrastructure
{
  public partial  class DependencyRegistrar: AbstractBadPayBadDependencyRegistrar<BadPayBadWidgetIframeObjectContext,BadPayBadWidgetIframe,BadPayBadWidgetIframeMap>
    {
      public override void InternalRegister(ContainerBuilder builder)
      {
            builder.RegisterType<BadPayBadWidgetIframeServices>().As<IBadPayBadWidgetIframeServices>().InstancePerLifetimeScope();

        }
    }
}
