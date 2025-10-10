using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class ProductCategoryRepository : IProductCategoryRepository
{
    private readonly List<ProductCategory> productcategorylist;
    
    public ProductCategoryRepository()
    {
        
        productcategorylist = [
            new ProductCategory(1, "Brood", 3, 1),
            new ProductCategory(2, "Cornflakes", 4, 1),
            new ProductCategory(1, "Cornflakes", 4, 1),
        ];
    }
    
    public ProductCategory? Get(string name)
    {
        return productcategorylist.FirstOrDefault(c => name == c.Name);
    }

    public List<ProductCategory> GetAll()
    {
        return productcategorylist;
    }
}