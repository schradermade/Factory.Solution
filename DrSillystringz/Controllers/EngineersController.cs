using Microsoft.AspNetCore.Mvc;
using DrSillystringz.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DrSillystringz.Controllers
{
  public class EngineersController : Controllers
  {
    private readonly DrSillystringzContext _db;

    public EngineersController(DrSillystringzContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }

    
  }
}