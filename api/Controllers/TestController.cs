string KEY = Configuration["MarketDataKeys:ApiKey"];

string url = BASE_URL + MARKET_STATUS;

namespace TestController.Controllers
{
    public class TestController : ControllerBase{

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        //need to understand how C# URLS work still
        public IActionResult getMarketStatus(){

        }
        
    
    }
}