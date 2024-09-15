namespace DesignPatterns.CompositeDesignPattern
{
    public class CompositeDesignPatternHandler
    {
        private readonly CompositeDesignPatternDb CategoryDb;
        public CompositeDesignPatternHandler()
        {
            CategoryDb = new CompositeDesignPatternDb();
        }
        public string GetProductCategoryHieararchy()
        {
            var categories = CategoryDb.Categories;
            var topCategory = categories.Find(x => x.ParentCategoryId == -1);
            _ = topCategory ?? throw new ArgumentNullException(nameof(topCategory));
            categories.Remove(topCategory);
            var productComposite = GetMenu(categories, topCategory, new ProductComposite()
            {
                Id = topCategory.Id,
                Name = topCategory.Name
            });
            return productComposite.Summary();

        }
        private ProductComposite GetMenu(List<Category> categories, Category topCategory, ProductComposite topProductComposite, ProductComposite? lastproductComposite = null)
        {
            categories.Where(x => x.ParentCategoryId == topCategory.Id).ToList().ForEach(categoryItem =>
            {
                var productComposite = new ProductComposite() { Id = categoryItem.Id, Name = categoryItem.Name };

                categoryItem.Products.ToList().ForEach(productItem =>
                {
                    productComposite.Products.Add(new ProductComponent() { Id = productItem.Id, Name = productItem.Name });

                });

                if (lastproductComposite != null)
                {
                    lastproductComposite.Products.Add(productComposite);
                }
                else
                {
                    topProductComposite.Products.Add(productComposite);
                }
                GetMenu(categories, categoryItem, topProductComposite, productComposite);
            });
            return topProductComposite;
        }

    }
}
