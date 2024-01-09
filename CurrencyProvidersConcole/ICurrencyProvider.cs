using System;
using System.Threading.Tasks;

namespace CurrencyProvidersConcole
{
    interface ICurrencyProvider
    {
        Task<string> GetNoneTradingDays();
    }
}
