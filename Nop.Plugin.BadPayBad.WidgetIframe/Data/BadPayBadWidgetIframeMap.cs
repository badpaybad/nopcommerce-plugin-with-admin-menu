using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.BadPayBad.WidgetIframe.Domain;

namespace Nop.Plugin.BadPayBad.WidgetIframe.Data
{
  public partial  class BadPayBadWidgetIframeMap: EntityTypeConfiguration<BadPayBadWidgetIframe>
    {
      public BadPayBadWidgetIframeMap()
      {
          ToTable("BadPayBadWidgetIframe");

          HasKey(i => i.Id);
          Property(i => i.UrlSource);
      }
    }
}
