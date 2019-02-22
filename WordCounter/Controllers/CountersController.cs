using Microsoft.AspNetCore.Mvc;
using WordCounterProject.Models;

namespace WordCounterProject.Controllers
{
  public class CountersController: Controller
  {
    [HttpGet("/counters/new")]
    public ActionResult New()
    {
    //  return new EmptyResult();
      return View();
    }
  }
}
