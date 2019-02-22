using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounterProject.Models;
using WordCounterProject.Controllers;

namespace WordCounterProject.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();
      ActionResult resultView = controller.Index();
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
  }
}
