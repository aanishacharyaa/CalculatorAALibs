using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace CalculatorAA.IntegrationTests
{
    public class CalculatorControllerTests : IClassFixture<WebApplicationFactory<CalculatorAA.Startup>>
    {
        private readonly HttpClient _client;

        public CalculatorControllerTests(WebApplicationFactory<CalculatorAA.Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task CalculatorIndex_ReturnsViewWithCorrectModel()
        {
            // Arrange

            // Act
            var response = await _client.GetAsync("/Calculator/Index");

            // Assert
            response.EnsureSuccessStatusCode(); // Status code 200-299
            Xunit.Assert.Contains("Calculator", await response.Content.ReadAsStringAsync()); // Check if the view content is present
        }

        // Add more integration tests for other controller actions, form submissions, etc.
    }
}
