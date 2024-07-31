using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Models;

namespace NewsApp.Services
{
    public interface INewsService
    {
        public Task<NewsResult> GetNews(NewsScope scope);
    }
}
