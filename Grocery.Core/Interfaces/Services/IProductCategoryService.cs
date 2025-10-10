using Grocery.Core.Models;
using Grocery.Core.Services;

namespace Grocery.Core.Interfaces.Services;

public interface IProductCategoryService
{
    public ProductCategory? Get(string name);

    public List<ProductCategory> GetAll();
}