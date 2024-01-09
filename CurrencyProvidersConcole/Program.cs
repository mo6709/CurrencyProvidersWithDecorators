using System;
using System.Threading.Tasks;

namespace CurrencyProvidersConcole
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Currency providers system");
            ICurrencyProvider currencyProvider = new CloudProviderInMemoryCacheDecorator(
                    new CloudProviderDistributedCacheDecorator(
                            new AfexCloudProvider()));

            while(true)
            {
                var days = await GetNoneTradingDays(currencyProvider);
                Console.WriteLine(days);
                Console.ReadLine();
            }
        }

        private static async Task<string> GetNoneTradingDays(ICurrencyProvider currencyProvider)
        {
            var ntd = await currencyProvider.GetNoneTradingDays();
            return ntd;
        }
    }
}
