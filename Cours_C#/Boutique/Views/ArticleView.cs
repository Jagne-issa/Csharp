using Boutique.Entities;
using Boutique.Services;
using System;
using System.Collections.Generic;

namespace Boutique.Views
{
    public class ArticleView
    {
        private readonly IArticleService _articleService;

        public ArticleView(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public void CreateArticle()
        {
            Console.Write("Enter article name: ");
            string name = Console.ReadLine();
            Console.Write("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter quantity in stock: ");
            int quantity = int.Parse(Console.ReadLine());

            Article article = new Article
            {
                Name = name,
                Price = price,
                QuantityInStock = quantity
            };
            _articleService.CreateArticle(article);
            Console.WriteLine("Article created successfully!");
        }

        public void ListAllArticles()
        {
            List<Article> articles = _articleService.GetAllArticles();
            Console.WriteLine("List of Articles:");
            foreach (var article in articles)
            {
                Console.WriteLine($"ID: {article.Id}, Name: {article.Name}, Price: {article.Price}, Quantity in Stock: {article.QuantityInStock}");
            }
        }

        public void ListAvailableArticles()
        {
            List<Article> articles = _articleService.GetAvailableArticles();
            Console.WriteLine("Available Articles:");
            foreach (var article in articles)
            {
                Console.WriteLine($"ID: {article.Id}, Name: {article.Name}, Price: {article.Price}, Quantity in Stock: {article.QuantityInStock}");
            }
        }

        internal void CreateOrListArticles()
        {
            throw new NotImplementedException();
        }

        internal void UpdateArticleStock()
        {
            throw new NotImplementedException();
        }
    }
}
