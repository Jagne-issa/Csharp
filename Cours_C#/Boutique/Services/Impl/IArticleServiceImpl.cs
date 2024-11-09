using Boutique.Entities;
using Boutique.Repositories;
using System.Collections.Generic;

namespace Boutique.Services
{
    public class ArticleServiceImpl : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleServiceImpl(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void CreateArticle(Article article) => _articleRepository.Add(article);

        public List<Article> GetAllArticles() => _articleRepository.GetAll();

        public List<Article> GetAvailableArticles() => _articleRepository.GetAvailableArticles();

        public void UpdateArticleStock(Article article, int newQuantity)
        {
            article.QuantityInStock = newQuantity;
            _articleRepository.Update(article);
        }
    }
}
