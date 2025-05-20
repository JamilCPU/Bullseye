using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using FinanceController.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FinanceController.Tests
{
    public class FinanceControllerTests
    {
        private readonly IConfiguration _configuration;
        private readonly Mock<ILogger<FinanceController>> _loggerMock;
        private readonly FinanceController _controller;

        public FinanceControllerTests()
        {
            _loggerMock = new Mock<ILogger<FinanceController>>();
            _controller = new FinanceController(_loggerMock.Object);
        }

        [Fact]
        public async Task<IActionResult> getMarketStatus_expect_ok()
        {
            // Act
            var result = await _controller.getMarketStatus();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
} 