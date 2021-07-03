using System.Collections.Generic;

namespace _01_LampShadeQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        //ProductCategoryQueryModel GetProductCategoryWithProducstsBy(string slug);
        List<ProductCategoryQueryModel> GetProductCategories();
        //List<ProductCategoryQueryModel> GetProductCategoriesWithProducts();
    }
}
