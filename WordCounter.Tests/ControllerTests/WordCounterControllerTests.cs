using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterProject.Models;
using WordCounterProject.Controllers;

namespace WordCounterProject.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void New_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();
      ActionResult resultView = controller.New();
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();
      ActionResult resultView = controller.Index();
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
    [TestMethod]
    public void Index_HasCorrectModelType_RepeatCounterList()
    {
      ViewResult indexView = new WordCounterController().Index() as ViewResult;
      var result = indexView.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(List<RepeatCounter>));
    }
  }
}
