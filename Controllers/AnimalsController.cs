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

<<<<<<< HEAD
=======
        //animalDetail.category = animals[i].category;
        //animalList.Add(animalDetail);
        //animalList.Add(animal);
        ViewBag.Country = country;
>>>>>>> 2b9175f88709dec4967663181680032c90e11cc0
      }
      return View(animalList);
    }

    public IActionResult Detail(string name)
    {
      Console.WriteLine("Name %%  " + name);
      Animal thisAnimal = Animal.GetDetails(name);
      var animalOverview = Animal.GetOverview(name);
      thisAnimal.category = animalOverview.category;
      thisAnimal.family = animalOverview.family;
      return View(thisAnimal);
    }

  }



}
