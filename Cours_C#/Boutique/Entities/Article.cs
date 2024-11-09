namespace Boutique.Entities
{
    public class Article
    {
        internal decimal Price;
        internal object Id;

        public string Name { get; set; }
        public int QuantityInStock { get; set; }

        public Article(string name, int quantityInStock)
        {
            Name = name;
            QuantityInStock = quantityInStock;
        }

        public Article() { }
    }
}
