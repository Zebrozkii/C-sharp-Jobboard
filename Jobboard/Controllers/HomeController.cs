using Microsoft.AspNetCore.Mvc;
using Jobboard.Models;

namespace Jobboard.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(JobOpening.GetAll());
    }

    [HttpGet("/new")]
    public ActionResult CreateJoboffer()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Create(string title, string description, string contact)
    {
      JobOpening job = new JobOpening(title, description, contact);
      return RedirectToAction("Index");
    }


  }
}
