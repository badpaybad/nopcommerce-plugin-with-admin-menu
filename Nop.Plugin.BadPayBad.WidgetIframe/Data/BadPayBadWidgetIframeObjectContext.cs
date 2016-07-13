using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Data;
using Nop.Plugin.BadPayBad.Core.Data;
using Nop.Plugin.BadPayBad.WidgetIframe.Domain;

namespace Nop.Plugin.BadPayBad.WidgetIframe.Data
{
  public partial  class BadPayBadWidgetIframeObjectContext:AbstractBadPaybadObjectContext<BadPayBadWidgetIframe,BadPayBadWidgetIframeMap>
  {
      public BadPayBadWidgetIframeObjectContext(string nameOrConnectionString) : base(nameOrConnectionString)
      {
      }

  }
}
