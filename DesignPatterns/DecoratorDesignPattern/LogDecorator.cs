namespace DesignPatterns.DecoratorDesignPattern
{
    public class LogDecorator : DecoratorAbstractClass, IDecoratorDesignPatternService
    {
        private readonly ILogger<LogDecorator> _logger;
        public LogDecorator(IDecoratorDesignPatternService decoratorDesignPatternService, ILogger<LogDecorator> logger) : base(decoratorDesignPatternService)
        {
            _logger = logger;
        }

        public override List<DecoratorDesignPatternProductDto> GetProducts()
        {
            _logger.LogInformation("Get Products isteği loglandı");
            return base.GetProducts();
        }
    }
}
