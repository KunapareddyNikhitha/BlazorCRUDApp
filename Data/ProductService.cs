namespace BlazorCRUDApp.Data
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Kitkat"
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Oreo"
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Cadboury"
            },
        };

        public void AddProduct(Product product)
        {
            var id = Guid.NewGuid();
            product.Id = id;
            products.Add(product);
        }

        public void DeleteProduct(Guid id)
        {
            var product = GetProduct(id);
            products.Remove(product);

        }

        public Product GetProduct(Guid id)
        {
            return products.SingleOrDefault(x => x.Id == id);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var getOldProduct = GetProduct(product.Id);
            getOldProduct.Name = product.Name;
        }
    }
}
