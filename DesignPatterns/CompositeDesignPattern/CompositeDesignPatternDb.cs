namespace DesignPatterns.CompositeDesignPattern
{
    public class CompositeDesignPatternDb
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public CompositeDesignPatternDb()
        {
            Categories = FillCategoryData();
            Products = this.Categories.SelectMany(x => x.Products).ToList();
        }
        private List<Category> FillCategoryData()
        {
            var categories = new List<Category>();
            var category = new Category(0, "Beyaz Eşya Kategori", -1);

            var category1 = new Category(1, "Buzdolabı Kategori", 0);

            category1.AddProduct(new Product(1, "Altus Buzdolabı Ürün", 1, category1));

            var category11 = new Category(11, "Arçelik Buzdolabı Kategori", 1);

            category11.AddProduct(new Product(2, "Arçelik Buzdolabı Ürün", 11, category11));

            var category12 = new Category(12, "Beko Buzdolabı Kategori", 1);

            category12.AddProduct(new Product(3, "Beko Buzdolabı Ürün", 12, category12));

            var category2 = new Category(2, "Çamaşır Makinesi Kategori", 0);

            category2.AddProduct(new Product(4, "Çamaşır Makinesi Ürün", 2, category2));

            categories.Add(category);
            categories.Add(category1);
            categories.Add(category11);
            categories.Add(category12);
            categories.Add(category2);
            return categories;
        }
    }


    public class Category
    {
        public Category(int ıd, string name, int parentCategoryId)
        {
            Id = ıd;
            Name = name;
            ParentCategoryId = parentCategoryId;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public List<Product> Products { get; set; }
    }
    public class Product
    {
        public Product(int id, string name, int categoryId, Category category)
        {
            Id = id;
            Name = name;
            CategoryId = categoryId;
            Category = category;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
