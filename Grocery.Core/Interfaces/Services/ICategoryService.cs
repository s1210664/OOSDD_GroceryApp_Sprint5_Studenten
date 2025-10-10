using Grocery.Core.Models;
using Grocery.Core.Services;

namespace Grocery.Core.Interfaces.Services;

public interface ICategoryService
{
    public Category? Get(int id);

    public List<Category> GetAll();
}