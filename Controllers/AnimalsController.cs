using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EndangeredAnimals.Models;
namespace EndangeredAnimals.Controllers
{  
  public class AnimalsController : Controller
  {
    public IActionResult Index(string country)
    {
      List<Animal> animalList = new List<Animal>();
      List<Animal> animals = Animal.GetAnimalsByCountry(country);
      foreach (Animal animal in animals)
      {
        if (EnvironmentVariables.OurAnimals.ContainsKey(animal.scientific_name))
        {
          var animalCommonName = Animal.GetAnimalsBySciName(animal.scientific_name);
          animal.taxonname = animalCommonName.taxonname;
          animal.imgURL = EnvironmentVariables.OurAnimals[animal.scientific_name];
          animalList.Add(animal);
        }

        //animalDetail.category = animals[i].category;
        //animalList.Add(animalDetail);
        //animalList.Add(animal);
        ViewBag.Country = country;
      }
      return View(animalList);
    }
  }
}