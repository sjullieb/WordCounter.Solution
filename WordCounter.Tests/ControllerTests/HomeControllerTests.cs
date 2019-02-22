using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.ASPNetCore.MVC;
using WordCounterProject.Models;
using WordCounterProject.Controllers;

namespace WordCounterProject.Tests;
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      HomeController controller = new HomeController();
      ViewResult result = controller.Index();
      Assert.IsInstanceTypeOf(result, typeof(ViewResult));
    }
  }
}
