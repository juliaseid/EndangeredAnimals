using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EndangeredAnimals.Models;
using System;

namespace EndangeredAnimals.Controllers
{                   
  public class USAController : Controller
  {
    public IActionResult Index()
    {
      Console.WriteLine("We madde it");
      return View();
    }
  } 
} 