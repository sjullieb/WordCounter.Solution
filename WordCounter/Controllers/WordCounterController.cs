using Microsoft.AspNetCore.Mvc;
using WordCounterProject.Models;
using System.Collections.Generic;

namespace WordCounterProject.Controllers
{
  public class WordCounterController: Controller
  {
    [HttpGet("/counters")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("all", RepeatCounter.GetAll());
      return View(model);
    }

    [HttpGet("/counters/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/counters")]
    public ActionResult Index(string word, string sentence)
    {
      RepeatCounter newCounter = new RepeatCounter(word, sentence);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("new", newCounter);
      model.Add("all", RepeatCounter.GetAll());
      return View("Index", model);
    }

    [HttpGet("/counters/{id}")]
    public ActionResult Show(int id)
    {
      return View(RepeatCounter.Find(id));
    }
  }
}
