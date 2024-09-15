namespace DesignPatterns.DecoratorDesignPattern
{
    public class DecoratorDesignPatternProductDto
    {
        public DecoratorDesignPatternProductDto(int id, string name, int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
