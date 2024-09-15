namespace DesignPatterns.AdapterDesignPattern
{
    public class AdapterDesignExistService : IAdapterDesignExistService
    {
        private readonly ILogger<AdapterDesignExistService> _logger;
        /// <summary>
        /// ExistService Constructor
        /// </summary>
        /// <param name="logger"></param>
        public AdapterDesignExistService(ILogger<AdapterDesignExistService> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// İki sayıyı çarpar
        /// </summary>
        /// <param name="number"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        public int MultiplyBySum(int number, int multiplier)
        {
            _logger.LogInformation("Toplama ile yapılan çarpma işlemi");
            var sum = 0;
            for (int i = 0; i < multiplier; i++)
            {
                sum += number;
            }
            return sum;
        }
    }
}
