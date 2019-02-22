using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounterProject.Models;
using WordCounterProject.Controllers;

namespace WordCounterProject.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      HomeController controller = new HomeController();
      ActionResult resultView = controller.Index();
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
  }
}
