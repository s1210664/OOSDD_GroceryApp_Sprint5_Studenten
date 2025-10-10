using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories;

public interface IProductCategoryRepository
{
    public ProductCategory? Get(string name);
    public List<ProductCategory> GetAll();
}