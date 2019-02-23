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
    public void Index_HasCorrectModelType_Dictionary()
    {
      ViewResult indexView = new WordCounterController().Index() as ViewResult;
      var result = indexView.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(Dictionary<string, object>));
    }
    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();
      RepeatCounter newCounter = new RepeatCounter("cat", "This is a cat.");
      ActionResult resultView = controller.Show(1);
      Assert.IsInstanceOfType(resultView, typeof(ViewResult));
    }
    [TestMethod]
    public void Show_HasCorrectModelType_RepeatCounter()
    {
      RepeatCounter newCounter = new RepeatCounter("cat", "This is a cat.");
      ViewResult indexView = new WordCounterController().Show(1) as ViewResult;
      var result = indexView.ViewData.Model;
      Assert.IsInstanceOfType(result, typeof(RepeatCounter));
    }
    [TestMethod]
    public void Index_AddNewRepeatCounter_True()
    {
      int oldNumberOfCounters = RepeatCounter.GetAll().Count;
      ActionResult result = new WordCounterController().Index("cat", "This is a cat");
      Assert.AreEqual(oldNumberOfCounters + 1, RepeatCounter.GetAll().Count);
    }


  }
}
