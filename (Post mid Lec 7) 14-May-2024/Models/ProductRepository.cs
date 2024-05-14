namespace WebApplication1.Models
{
    public class ProductRepository
    {
        public void Add(Product product) { 
        
        
        /*
         db code 
         */
        
        }
        public void Update(Product product) { }
        public void Delete(Product product) { }
        public void DeleteAll() { }
        public void DeleteById(int id) { }
        public void DeleteByName(string name) { }
        public Product Get()
        {
            return new Product();
        }
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name="Mobile", Description="this is a mobile" });
            products.Add(new Product { Name = "Computer", Description = "this is a computer" });
            products.Add(new Product { Name = "Laptop", Description = "this is a laptop" });

            return products;
        }
    }
}
