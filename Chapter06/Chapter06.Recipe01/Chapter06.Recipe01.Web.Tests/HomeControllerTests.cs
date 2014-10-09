using System;
using Xunit;
using Chapter06.Recipe01.Web.Controllers;
using Microsoft.AspNet.Mvc;

namespace Chapter06.Recipe01.Web.Tests
{
    /// <summary>
    /// Summary description for HomeControllerTests
    /// </summary>
    public class HomeControllerTests
    {
        [Fact]
        public void IndexAction_ReturnsMessageInViewBag()
        {
            // Arrange
            HomeController controller = new HomeController();
            var expected = "Index";

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.Equal(expected, result.ViewName);
        }

    }
}