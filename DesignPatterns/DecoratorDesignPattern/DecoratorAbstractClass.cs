namespace DesignPatterns.DecoratorDesignPattern
{
    public class DecoratorAbstractClass : IDecoratorDesignPatternService
    {
        private IDecoratorDesignPatternService _decoratorDesignPatternService { get; set; }

        public DecoratorAbstractClass(IDecoratorDesignPatternService decoratorDesignPatternService)
        {
            _decoratorDesignPatternService = decoratorDesignPatternService;
        }

        public virtual List<DecoratorDesignPatternProductDto> GetProducts()
        {
            return _decoratorDesignPatternService.GetProducts();
        }
    }
}
