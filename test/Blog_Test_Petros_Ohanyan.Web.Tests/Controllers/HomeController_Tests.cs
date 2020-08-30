using System.Threading.Tasks;
using Blog_Test_Petros_Ohanyan.Models.TokenAuth;
using Blog_Test_Petros_Ohanyan.Web.Controllers;
using Shouldly;
using Xunit;

namespace Blog_Test_Petros_Ohanyan.Web.Tests.Controllers
{
    public class HomeController_Tests: Blog_Test_Petros_OhanyanWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}