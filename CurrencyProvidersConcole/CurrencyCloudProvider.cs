using System;
using System.Threading.Tasks;
namespace CurrencyProvidersConcole 
{
    class CurrencyCloudProvider : ICurrencyProvider
    {
        public async Task<string> GetNoneTradingDays()
        {
            // Get CC Authorization

            // Call CC GetNoneTradingDays

            //return the value
            Console.WriteLine($"[CurrencyCloud] {DateTime.Now} - Loading from Currency Cloud");
            return "Monday, Tuesday";
        }
    }
}