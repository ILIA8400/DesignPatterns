using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class News : INewsService
    {
        public string LatestNews()
        {
            return $"The latest news at the time : {DateTime.Now}";
        }
    }
}
