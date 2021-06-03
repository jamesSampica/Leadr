using FluentAssertions;
using Leadr.Tests.Helpers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Leadr.Tests.Controllers.EmployeeControllerTests
{
    public class CreateTests
    {
        private readonly TestWebApplicationFactory _factory;

        public CreateTests()
        {
            _factory = new TestWebApplicationFactory();
        }

        [Fact]
        public async Task WithNullName_ReturnsBadRequest()
        {
            //arrange
            var client = _factory.CreateDefaultClient();

            var json = JsonConvert.SerializeObject(
                new { 
                    name = (string)null, 
                    title = "Web Developer", 
                    managerIds = new[] { 1, 2 } 
                });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //act
            var result = await client.PostAsync("/Employee/Create", content);

            //assert
            result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }

        [Fact]
        public async Task WithNullTitle_ReturnsBadRequest()
        {
            //arrange
            var client = _factory.CreateDefaultClient();

            var json = JsonConvert.SerializeObject(
                new
                {
                    name = "John Doe",
                    title = (string)null,
                    managerIds = new[] { 1, 2 }
                });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //act
            var result = await client.PostAsync("/Employee/Create", content);

            //assert
            result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }

        [Fact]
        public async Task WhenEmployeeExists_ReturnsBadRequest()
        {
            //arrange
            var client = _factory.CreateDefaultClient();

            var json = JsonConvert.SerializeObject(
                new
                {
                    name = "John Doe",
                    title = "Web Developer",
                    managerIds = new[] { 1, 2 }
                });

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await client.PostAsync("/Employee/Create", content);

            //act
            var result = await client.PostAsync("/Employee/Create", content);

            //assert
            result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }
    }
}
