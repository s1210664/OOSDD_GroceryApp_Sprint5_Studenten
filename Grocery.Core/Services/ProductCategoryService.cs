using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services;

public class ProductCategoryService : IProductCategoryService
{
    
    private readonly IProductCategoryService _productcategoryRepository;
    public ProductCategoryService(IProductCategoryService productcategoryRepository)
    {
        _productcategoryRepository = productcategoryRepository;
    }
    
    public ProductCategory? Get(string name)
    {
        return _productcategoryRepository.Get(name);
    }

    public List<ProductCategory> GetAll()
    {
        return _productcategoryRepository.GetAll();
    }
}