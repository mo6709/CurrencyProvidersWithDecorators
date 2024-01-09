class AfexCloudProvider : ICurrencyProvider
{
    public async Task<string> GetNoneTradingDays()
    {
        // Get Afex API KEY

        // Call afex GetNoneTradingDays

        //return the value
        Console.WriteLine($"[AfexCloudProvider] {DateTime.Now} - Loading from Afex");
        return "Monday, Tuesday";
    }
}