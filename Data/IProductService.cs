namespace BlazorCRUDApp.Data
{
    public interface IProductService
    {
        List<Product> GetProducts();

        Product GetProduct(Guid id);
        void UpdateProduct(Product product);
        void DeleteProduct(Guid id);
        void AddProduct(Product product);
    }
}
