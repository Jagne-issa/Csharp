using Boutique.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Boutique.Repositories
{
    public class ArticleRepositoryImpl : IArticleRepository
    {
        private List<Article> articles = new List<Article>();

        public void Add(Article article) => articles.Add(article);
        public void Update(Article article)
        {
            var existingArticle = articles.FirstOrDefault(a => a.Name == article.Name);
            if (existingArticle != null)
            {
                existingArticle.QuantityInStock = article.QuantityInStock;
            }
        }
        public void Delete(Article article) => articles.Remove(article);
        public Article GetById(int id) => id >= 0 && id < articles.Count ? articles[id] : null;
        public List<Article> GetAll() => articles;

        public List<Article> GetAvailableArticles() => articles.Where(a => a.QuantityInStock > 0).ToList();
    }
}
