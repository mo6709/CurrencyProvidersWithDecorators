using System;
using System.Threading.Tasks;

namespace CurrencyProvidersConcole
{
    public class CloudProviderInMemoryCacheDecorator : ICurrencyProvider
    {
        private readonly ICurrencyProvider _component;
        private string _cache;
        private DateTime expires;

        public CloudProviderInMemoryCacheDecorator(ICurrencyProvider component)
        {
            _component = component;
        }

        public async Task<string> GetNoneTradingDays()
        {
            if (!string.IsNullOrEmpty(_cache) && expires > DateTime.Now) return _cache;
            Console.WriteLine($"[CloudProviderInMemoryCacheDecorator] {DateTime.Now} - Loading from next componenet");
            _cache = await _component.GetNoneTradingDays();
            expires = DateTime.Now.AddMinutes(1);
            return _cache;
        }
    }
}
