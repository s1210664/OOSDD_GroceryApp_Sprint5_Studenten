namespace Grocery.Core.Models
{
    public class ProductCategory : Category

    {
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    

    public ProductCategory(int id, string name, int productId, int categoryId) : base(categoryId, name)
    {
        Id = id;
        ProductId = productId;
        CategoryId = categoryId;
    }
    }


}

