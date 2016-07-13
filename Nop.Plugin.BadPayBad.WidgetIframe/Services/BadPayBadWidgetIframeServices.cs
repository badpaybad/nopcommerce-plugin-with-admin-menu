using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Data;
using Nop.Plugin.BadPayBad.WidgetIframe.Data;
using Nop.Plugin.BadPayBad.WidgetIframe.Domain;

namespace Nop.Plugin.BadPayBad.WidgetIframe.Services
{
    public interface IBadPayBadWidgetIframeServices
    {
        void Set(BadPayBadWidgetIframe data);
        BadPayBadWidgetIframe Get();
    }

    public partial class BadPayBadWidgetIframeServices : IBadPayBadWidgetIframeServices
    {
        private BadPayBadWidgetIframeObjectContext _dbContext;
        private IBadPayBadWidgetIframeServices _widgetIframeServices;
        private IRepository<BadPayBadWidgetIframe> _repository;

        public BadPayBadWidgetIframeServices(BadPayBadWidgetIframeObjectContext dbContext,
            IRepository<BadPayBadWidgetIframe> repository)
        {
            _dbContext = dbContext;
            _repository = repository;
        }

        public void Set(BadPayBadWidgetIframe data)
        {
            var xxx = _repository.Table.FirstOrDefault();
            if (xxx == null)
            {
                var badPayBadWidgetIframe = new BadPayBadWidgetIframe() {UrlSource = data.UrlSource, Id = data.Id};
                _repository.Insert(badPayBadWidgetIframe);
            }

            xxx = _repository.Table.FirstOrDefault();
            xxx.UrlSource = data.UrlSource;
            xxx.Id = data.Id;

            _repository.Update(xxx);
        }

        public BadPayBadWidgetIframe Get()
        {
            var xxx = _repository.Table.FirstOrDefault();
            if (xxx != null) return xxx;

            var badPayBadWidgetIframe = new BadPayBadWidgetIframe() {UrlSource = "", Id = 1};
            _repository.Insert(badPayBadWidgetIframe);

            return badPayBadWidgetIframe;
        }
    }
}