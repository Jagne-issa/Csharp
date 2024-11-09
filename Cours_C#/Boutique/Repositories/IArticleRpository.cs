using Boutique.Entities;
using System.Collections.Generic;

namespace Boutique.Repositories
{
    public interface IArticleRepository : IRepository<Article>
    {
        List<Article> GetAvailableArticles();
    }
}
