namespace DesignPatterns.CompositeDesignPattern
{
    public interface IProductComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IProductComponent> Products { get; set; }
        public int ProductCount();
        public string Summary();
    }
}
