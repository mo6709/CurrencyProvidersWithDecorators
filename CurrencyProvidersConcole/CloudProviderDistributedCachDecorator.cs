using System;
using System.Threading.Tasks;
namespace CurrencyProvidersConcole 
{
    class CloudProviderDistributedCacheDecorator : ICurrencyProvider
    {
        private readonly ICurrencyProvider _component;
        private string _cache;
        private DateTime expires;

        public CloudProviderDistributedCacheDecorator(ICurrencyProvider component)
        {
            _component = component;
        }

        public async Task<string> GetNoneTradingDays()
        {
            if (!string.IsNullOrEmpty(_cache) && expires > DateTime.Now) return _cache;
            Console.WriteLine($"[CloudProviderDistributedCacheDecorator] {DateTime.Now} - Loading from next componenet");
            _cache = await _component.GetNoneTradingDays();
            expires = DateTime.Now.AddMinutes(2);
            return _cache;
        }
    }
}