﻿using _01_LampshadeQuery.Contracts.ProductCategory;
using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.ArticleCategory;

namespace _01_LampshadeQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}
