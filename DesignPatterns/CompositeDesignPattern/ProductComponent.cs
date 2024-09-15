namespace DesignPatterns.CompositeDesignPattern
{
    public class ProductComponent : IProductComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IProductComponent> Products { get; set; } = new List<IProductComponent>();

        public int ProductCount()
        {
            return 1;
        }

        public string Summary()
        {
            return $"Bu bir üründür.{Id}-{Name}\n";
        }
    }
}
