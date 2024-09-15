namespace DesignPatterns.AdapterDesignPattern
{
    public class AdapterDesignNewService : IAdapterDesignNewService
    {

        private readonly ILogger<AdapterDesignNewService> _logger;

        public AdapterDesignNewService(ILogger<AdapterDesignNewService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Çarpma işlemi kullanarak çarpma yapar
        /// </summary>
        /// <param name="number"></param>
        /// <param name="multiplier"></param>
        /// <param name="anotherParamFromExistService"></param>
        /// <returns></returns>
        public int Multiply(int number, int multiplier, int anotherParamFromExistService)
        {
            _logger.LogInformation("Çarpma işlemi ile çarpma");
            return number * multiplier;
        }
    }
}
