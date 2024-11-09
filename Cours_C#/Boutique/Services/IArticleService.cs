using Boutique.Entities;
using Boutique.Entities;
using System.Collections.Generic;

namespace Boutique.Services
{
    public interface IArticleService
    {
        void CreateArticle(Article article);
        List<Article> GetAllArticles();
        List<Article> GetAvailableArticles();
        void UpdateArticleStock(Article article, int newQuantity);
    }
}
