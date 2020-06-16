using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EndangeredAnimals.Models
{
  public class Animal
  {
    //First block of params come from Individual Species query
    public int TaxonId;
    public string SciName;
    public string Family;
    public string CommonName;
    public string Category;
    public string Population_Trend;

    //The following params come from Narrative query
    public string Population;
    public string GeographicRange;
    public string Habitat;
    public string Threats;
    public string Conservation;
    //This param comes from Countries by Species query
    public List<string> Countries;
    //This param comes from Threats query
    public IDictionary<string, string> ThreatRatings;
    public string ImageURL;

  }

}