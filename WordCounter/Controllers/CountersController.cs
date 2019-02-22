using Microsoft.AspNetCore.Mvc;
using WordCounterProject.Models;

namespace WordCounterProject.Controllers
{
  public class WordCounterController: Controller
  {
    [HttpGet("/counters")]
    public ActionResult Index()
    {
      return View(RepeatCounter.GetAll());
    }

    [HttpGet("/counters/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
