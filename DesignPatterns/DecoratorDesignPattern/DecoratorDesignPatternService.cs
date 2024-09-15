namespace DesignPatterns.DecoratorDesignPattern
{
    public class DecoratorDesignPatternService : IDecoratorDesignPatternService
    {
        public List<DecoratorDesignPatternProductDto> GetProducts()
        {
            return new List<DecoratorDesignPatternProductDto>()
           {
               new(1,"Ürün1",0),
               new(2,"Ürün2",0),
               new(3,"Ürün3",0)
           };
        }
    }
}
