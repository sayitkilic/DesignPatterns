namespace DesignPatterns.DecoratorDesignPattern
{
    public class CacheDecorator : DecoratorAbstractClass, IDecoratorDesignPatternService
    {
        private readonly ILogger<CacheDecorator> _logger;
        public CacheDecorator(IDecoratorDesignPatternService decoratorDesignPatternService, ILogger<CacheDecorator> logger) : base(decoratorDesignPatternService)
        {
            _logger = logger;
        }

        public override List<DecoratorDesignPatternProductDto> GetProducts()
        {
           // İşlemlerin gözlemlenmesi açısından sadece log atıldı.
            _logger.LogInformation("Get Product response cachelendi.");
            return base.GetProducts();
        }
    }
}
