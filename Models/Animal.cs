using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EndangeredAnimals.Models
{
  public class Animal
  {
    //First block of params come from Individual Species query
    //public int AnimalId { get; set; }
    public int taxonid;
    public string scientific_name;

    //public string CommonName;
    public string category;
    public string rationale;
    public string populationtrend;

    //The following params come from Narrative query
    public string population;

    public string geographicrange;
    public string habitat;
    public string threats;
    public string conservationmeasures;
    //This param comes from Countries by Species query
    public string country;
    //This param comes from Threats query
    //public IDictionary<string, string> ThreatRatings;
    public static Dictionary<string, string> DictAnimals = new Dictionary<string, string>
    {
        {"Gymnogyps californianus", "California condor"},
        {"Ambystoma mexicanum", "Axolotl"},
        {"Marmota vancouverensis", "Vancouver Marmot"},
        {"Procyon pygmaeus", "Pygmy Raccoon"},
        {"Canis rufus", "Red Wolf"},
        {"Lepidochelys kempii", "Kemp's ridley sea turtle"},
        {"Mustela nigripes", "Black-Footed Ferret"},
        {"Eubalaena glacialis", "North Atlantic Right Whale"},
        {"Amazona viridigenalis", "Red-crowned Amazo"},
        {"Ateles geoffroyi", "Geoffroy's spider monkey"}

    };

    public static List<Animal> GetAnimalsByCountry(String country)
    {
      var apiCallTask = ApiHelper.GetAll(country);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      //JObject  jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Animal> animalList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse["result"].ToString());

      return animalList;
    }

    public static Animal GetAnimalsBySciName(String sciName)
    {
      var apiCallTask = ApiHelper.GetDetails(sciName);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Animal animal = JsonConvert.DeserializeObject<Animal>(jsonResponse.ToString());

      return animal;
    }

  }

}