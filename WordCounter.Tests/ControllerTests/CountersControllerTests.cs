using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounterProject.Models;
using WordCounterProject.Controllers;

namespace WordCounterProject.Tests
{
  [TestClass]
  public class CounterControllerTest
  {
    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      CountersController controller = new CountersController();
      ActionResult resultView = controller.New();
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      CountersController controller = new CountersController();
      ActionResult resultView = controller.Index();
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
  }
}
