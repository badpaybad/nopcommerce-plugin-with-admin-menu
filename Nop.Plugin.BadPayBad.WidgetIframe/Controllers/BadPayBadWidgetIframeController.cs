using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Nop.Plugin.BadPayBad.Core;
using Nop.Plugin.BadPayBad.Core.Models;
using Nop.Plugin.BadPayBad.WidgetIframe.Domain;
using Nop.Plugin.BadPayBad.WidgetIframe.Models;
using Nop.Plugin.BadPayBad.WidgetIframe.Services;
using Nop.Web.Framework.Controllers;


namespace Nop.Plugin.BadPayBad.WidgetIframe.Controllers
{
    public class BadPayBadWidgetIframeController : BasePluginController
    {
        private IBadPayBadWidgetIframeServices _widgetIframeServices;

        public BadPayBadWidgetIframeController(IBadPayBadWidgetIframeServices widgetIframeServices)
        {
            _widgetIframeServices = widgetIframeServices;
        }
        public ActionResult FrontEnd()
        {
            var model = new BadPayBadWidgetIframeModel();
            var xxx = _widgetIframeServices.Get();
            model.UrlSrouce = xxx.UrlSource;

            return PartialView("~/Plugins/BadPayBad.WidgetIframe/Views/BadPayBadWidgetIframe/FrontEnd.cshtml", model);
        }


        public ActionResult Config()
        {
            var model = new BadPayBadWidgetIframeModel();
            var xxx = _widgetIframeServices.Get();
            model.UrlSrouce = xxx.UrlSource;
            return PartialView("~/Plugins/BadPayBad.WidgetIframe/Views/BadPayBadWidgetIframe/Config.cshtml", model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Config(string urlSource)
        {
            var model = new BadPayBadWidgetIframeModel();
            model.UrlSrouce = urlSource;
            var xxx = _widgetIframeServices.Get();
            xxx.UrlSource = urlSource;
            _widgetIframeServices.Set(xxx);

            return PartialView("~/Plugins/BadPayBad.WidgetIframe/Views/BadPayBadWidgetIframe/Config.cshtml", model);
        }
    }
    
}