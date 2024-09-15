namespace DesignPatterns.AdapterDesignPattern
{
    /// <summary>
    /// Adapter Design Exist Multiply Operation
    /// </summary>
    public interface IAdapterDesignExistService
    {
        /// <summary>
        /// Multiplies by summing
        /// </summary>
        /// <param name="number"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>
        int MultiplyBySum(int number, int multiplier);
    }
}
