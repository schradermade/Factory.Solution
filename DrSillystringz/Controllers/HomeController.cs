using Microsoft.AspNetCore.Mvc;
using DrSillystringz.Models;
using System.Collections.Generic;

namespace DrSillystringz.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}