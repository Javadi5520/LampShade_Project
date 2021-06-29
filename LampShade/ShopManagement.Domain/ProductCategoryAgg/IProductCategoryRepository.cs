﻿using ShopManagement.Application.Contracts.ProductCategory;
using System.Collections.Generic;
using _0_Framework.Domain;


namespace ShopManagement.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository : IRepository<long, ProductCategory>
    {
        
        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
        List<ProductCategoryViewModel> GetProductCategories();
    }
}