using System.Text;

namespace DesignPatterns.CompositeDesignPattern
{
    public class ProductComposite : IProductComponent
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public List<IProductComponent> Products { get; set; } = new List<IProductComponent>();

        public int ProductCount()
        {
            return Products.Sum(x => x.Products.Count);
        }

        public string Summary()
        {
            var sb = new StringBuilder();
            sb.Append($"Bu bir kategoridir. {Id}-{Name} \n");
            Products.ForEach(x => sb.Append(x.Summary()));
            return sb.ToString();
        }
    }
}
