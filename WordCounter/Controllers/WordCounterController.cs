using Microsoft.AspNetCore.Mvc;
using WordCounterProject.Models;

namespace WordCounterProject.Controllers
{
  public class WordCounterController: Controller
  {
    [HttpGet("/wordcounters")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
