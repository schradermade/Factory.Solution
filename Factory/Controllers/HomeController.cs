using Microsoft.AspNetCore.Mvc;
using DrSillystringz.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrSillystringz.Controllers
{
  public class HomeController : Controller
  {
    private readonly DrSillystringzContext _db;
    public HomeController(DrSillystringzContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Machine> machineList = _db.Machines.ToList();
      List<Engineer> engineerList = _db.Engineers.ToList();
      
      Dictionary<string, object> myDictionary = new Dictionary<string, object> ();
      myDictionary.Add("Machine", machineList);
      myDictionary.Add("Engineer", engineerList);
      return View(myDictionary);
    }
  }
}