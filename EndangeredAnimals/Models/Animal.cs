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
      var apiCallTask = ApiHelper.GetAll(sciName);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Animal animal = JsonConvert.DeserializeObject<Animal>(jsonResponse.ToString());

      return animal;
    }

  }

}