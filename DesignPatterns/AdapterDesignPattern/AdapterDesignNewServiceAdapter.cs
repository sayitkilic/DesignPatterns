namespace DesignPatterns.AdapterDesignPattern
{
    public class AdapterDesignNewServiceAdapter : IAdapterDesignExistService
    {
        private readonly IAdapterDesignNewService _newService;

        public AdapterDesignNewServiceAdapter(IAdapterDesignNewService newService)
        {
            _newService = newService;
        }

        public int MultiplyBySum(int number, int multiplier)
        {
            return _newService.Multiply(number, multiplier, 999);
        }
    }
}
