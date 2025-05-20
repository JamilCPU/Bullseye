

namespace FinanceController.Controllers
{
    string KEY = Configuration["MarketDataKeys:ApiKey"];

    public class FinanceController : ControllerBase
    {

        private readonly ILogger<FinanceController> _logger;

        public FinanceController(ILogger<FinanceController> logger)
        {
            _logger = logger;
        }

        //need to understand how C# URLS work still
        public async Task<IActionResult> getMarketStatus()
        {
            string url = BASE_URL + MARKET_STATUS;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-API-KEY", KEY);

                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        return Ok(content);
                    }

                    return StatusCode((int)response.StatusCode, "Failed to get market status");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting market status");
                return StatusCode(500, "Internal server error");
            }
        }


    }
}