using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using Nop.Plugin.BadPayBad.Core;
using Nop.Plugin.BadPayBad.WidgetIframe.Data;

namespace Nop.Plugin.BadPayBad.WidgetIframe
{
    public class BadPayBadWidgetIframeNopPlugin : AbstractBadPayBadPlugin
    {
        private BadPayBadWidgetIframeObjectContext _widgetIframeObjectContext;

        public BadPayBadWidgetIframeNopPlugin(BadPayBadWidgetIframeObjectContext widgetIframeObjectContext) : base()
        {
            _widgetIframeObjectContext = widgetIframeObjectContext;
        }

        public override void InternalInitMenu(out string title, out string menuIconUrl)
        {
            title = "Widget Iframe";
            menuIconUrl = "";
        }

        protected override void InternalInitAdmin(out string actionName, out string controllerName,
            out string nampeSpaceOfController, out RouteValueDictionary routeVals)
        {
            actionName = "Config";
            controllerName = "BadPayBadWidgetIframe";
            nampeSpaceOfController = "Nop.Plugin.BadPayBad.WidgetIframe.Controllers";
            routeVals = null;
        }

        protected override void InternalInitFrontEnd(out string actionName, out string controllerName,
            out string nampeSpaceOfController, out RouteValueDictionary routeVals)
        {
            actionName = "FrontEnd";
            controllerName = "BadPayBadWidgetIframe";
            nampeSpaceOfController = "Nop.Plugin.BadPayBad.WidgetIframe.Controllers";
            routeVals = null;
        }
        
        public override void InternalInstall()
        {
            _widgetIframeObjectContext.Install();
        }

        public override void InternalUninstall()
        {
            _widgetIframeObjectContext.Uninstall();
        }
    }
}