using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class NewsServiceProxy : INewsService
    {
        private readonly INewsService service;
        private string cache = "";
        private DateTime latestCacheUpdate = DateTime.Now;

        public NewsServiceProxy(INewsService service)
        {
            this.service = service;
        }

        public string LatestNews()
        {
            CheckCacheUpdate();

            if (cache == "") 
            {
                string news = service.LatestNews();
                cache = news;
                return news;
            }
            else
            {
                return cache;
            }
        }

        public void CheckCacheUpdate()
        {
            if (DateTime.Now.Minute != latestCacheUpdate.Minute)
            {
                cache = "";
            }
        }
    }
}
