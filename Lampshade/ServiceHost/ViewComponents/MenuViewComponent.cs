﻿using _01_LampshadeQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IProductCategoryQuery _productCategoryQuery;
        //private readonly IArticleCategoryQuery _articleCategoryQuery;
        public MenuViewComponent(IProductCategoryQuery productCategoryQuery)
        {
            _productCategoryQuery = productCategoryQuery;
        }
        //public MenuViewComponent(IProductCategoryQuery productCategoryQuery, IArticleCategoryQuery articleCategoryQuery)
        //{
        //    _articleCategoryQuery = articleCategoryQuery;
        //    _productCategoryQuery = productCategoryQuery;
        //}

        public IViewComponentResult Invoke()
        {
            var result = new _01_LampshadeQuery.MenuModel
            {
               // ArticleCategories = _articleCategoryQuery.GetArticleCategories(),
                ProductCategories = _productCategoryQuery.GetProductCategories()
            };
            return View(result);
        }
    }
}
