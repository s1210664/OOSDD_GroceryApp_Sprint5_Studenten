using System.Collections.ObjectModel;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels;

public class CategoriesViewModel : BaseViewModel
{
    private readonly ICategoryService _categoryservice;
    public ObservableCollection<Category> Products { get; set; }

    public CategoriesViewModel()
    {

    }
}