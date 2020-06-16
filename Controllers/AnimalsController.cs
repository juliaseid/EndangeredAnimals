using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EndangeredAnimals.Models;
using System;
namespace EndangeredAnimals.Controllers
{
  public class AnimalsController : Controller
  {
    public IActionResult Index(string country)
    {
      List<Animal> animalList = new List<Animal>();
      List<Animal> animals = Animal.GetAnimalsByCountry(country);
      for (int i = 0; i < 25; i++)
      {

        //var animalDetail = Animal.GetAnimalsBySciName(animals[i].scientific_name);
        //animalDetail.category = animals[i].category;
        //animalList.Add(animalDetail);
        animalList.Add(animals[i]);

      }
      //for each animal in API response 
      //{
      //if (EnvironmentVariables CAAnimals.Contains(animal.scientific_name))
      //{
      //          animalList.Add(animalDetail)
      //      }
      return View(animalList);
    }
  }
}