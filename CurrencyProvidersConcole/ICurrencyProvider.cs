using System;
using System.Threading.Tasks;

namespace CurrencyProvidersConcole
{
    public interface ICurrencyProvider
    {
        Task<string> GetNoneTradingDays();
    }
}
