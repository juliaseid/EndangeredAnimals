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
    //taxonname is Common Name from API
    public string taxonname { get; set; }
    public string family { get; set; }
    public string category { get; set; }
    public string rationale;
    public string populationtrend;
    public string main_common_name;

    //The following params come from Narrative query
    public string population;

    public string geographicrange;
    public string habitat;
    public string threats;
    public string conservationmeasures;
    //This param comes from Countries by Species query
    public string country;
    public string imgURL;

    public static Dictionary<string, RedApiRespons> apiResponseCache = new Dictionary<string, RedApiRespons>{};

    private static int expireMinitues = 10;

    public static List<Animal> GetAnimalsByCountry(String country)
    {
      // api cacheing
      var key = "GetAnimalsByCountry-" + country;
      var result = "";
      if (apiResponseCache.ContainsKey(key) == false || apiResponseCache[key].ExpirationTime.Subtract(DateTime.Now).TotalSeconds < 0)
      {
        
        var apiCallTask = ApiHelper.GetAll(country);
        result = apiCallTask.Result;
        if (apiResponseCache.ContainsKey(key))
        {
          apiResponseCache.Remove(key);
        }
        apiResponseCache.Add(key, new RedApiRespons() { ApiRespons = result, ExpirationTime = DateTime.Now.AddMinutes(expireMinitues) });

      }
      else
      {
                result = apiResponseCache[key].ApiRespons;
      }

      //end api cacheing
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Animal> animalList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse["result"].ToString());

      return animalList;
    }

    public static Animal GetAnimalsBySciName(String sciName)
    {
      //api cache
      var key = "GetAnimalsBySciName-" + sciName;
      var result = "";
      if (apiResponseCache.ContainsKey(key) == false || apiResponseCache[key].ExpirationTime.Subtract(DateTime.Now).TotalSeconds < 0)
      {
        
        var apiCallTask = ApiHelper.GetCommonName(sciName);
        result = apiCallTask.Result;
        if (apiResponseCache.ContainsKey(key))
        {
          apiResponseCache.Remove(key);
        }
        apiResponseCache.Add(key, new RedApiRespons() { ApiRespons = result, ExpirationTime = DateTime.Now.AddMinutes(expireMinitues) });
      }
      else
      {
        
        result = apiResponseCache[key].ApiRespons;
      }


      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Animal> animalList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse["result"].ToString());

      return animalList?[0]; //safe nevigator
    }

    public static Animal GetOverview(string scientific_name)
    {
      //api cache
      var key = "GetOverview-" + scientific_name;
      var result = "";
      if (apiResponseCache.ContainsKey(key) == false || apiResponseCache[key].ExpirationTime.Subtract(DateTime.Now).TotalSeconds < 0)
      {
      
        var apiCallTask = ApiHelper.GetOverview(scientific_name);
        result = apiCallTask.Result;
        if (apiResponseCache.ContainsKey(key))
        {
          apiResponseCache.Remove(key);
        }
        apiResponseCache.Add(key, new RedApiRespons() { ApiRespons = result, ExpirationTime = DateTime.Now.AddMinutes(expireMinitues) });
      }
      else
      {
        
        result = apiResponseCache[key].ApiRespons;
      }


      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Animal> animals = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse["result"].ToString());

      return animals?[0];
    }

    public static Animal GetDetails(string scientific_name)
    {
      //api cache
      var key = "GetDetails-" + scientific_name;
      var result = "";
      if (apiResponseCache.ContainsKey(key) == false || apiResponseCache[key].ExpirationTime.Subtract(DateTime.Now).TotalSeconds < 0)
      {
       
        var apiCallTask = ApiHelper.GetDetails(scientific_name);
        result = apiCallTask.Result;
        if (apiResponseCache.ContainsKey(key))
        {
          apiResponseCache.Remove(key);
        }
        apiResponseCache.Add(key, new RedApiRespons() { ApiRespons = result, ExpirationTime = DateTime.Now.AddMinutes(expireMinitues) });
      }
      else
      {

        result = apiResponseCache[key].ApiRespons;
      }


      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Animal> animals = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse["result"].ToString());

      return animals?[0];

    }
  }

}