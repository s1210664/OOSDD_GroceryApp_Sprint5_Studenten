using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> categorylist;

    public CategoryRepository()
    {
        categorylist = [
            new Category(1, "Veganistisch"),
            new Category(2, "Ontbijt"),
            new Category(3, "dranken")
        ];
    }
    
    public Category? Get(int id)
    {
        return categorylist.FirstOrDefault(c => id == c.Id);
    }

    public List<Category> GetAll()
    {
        return categorylist;
    }
}