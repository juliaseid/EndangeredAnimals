using System.Threading.Tasks;
using RestSharp;
using System;
namespace EndangeredAnimals.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll(string country)
    {
      //http://apiv3.iucnredlist.org/api/v3/country/getspecies/MX?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee
      RestClient client = new RestClient("http://apiv3.iucnredlist.org/api/v3/country/getspecies");
      RestRequest request = new RestRequest($"{country}?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee", Method.GET);

      var response = await client.ExecuteTaskAsync(request);
      Console.WriteLine("URL:" + response.ResponseUri);
      return response.Content;
    }
    public static async Task<string> GetCommonName(string sciName)
    {
      // string sciNameEncoded = HttpUtility.UrlEncode(sciName.ToLower());
      //http://apiv3.iucnredlist.org/api/v3/species/common_names/loxodonta%20africana?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee
      RestClient client = new RestClient("http://apiv3.iucnredlist.org/api/v3/species/common_names");
      RestRequest request = new RestRequest($"{sciName.ToLower()}?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee", Method.GET);

      var response = await client.ExecuteTaskAsync(request);
      Console.WriteLine("Name URL: " + response.ResponseUri);
      return response.Content;
    }
    //http://apiv3.iucnredlist.org/api/v3/species/narrative/Gymnogyps%20californianus?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee
    public static async Task<string> GetDetails(string sciName)
    {
      Console.WriteLine(sciName + "   sci -----");
      RestClient client = new RestClient("http://apiv3.iucnredlist.org/api/v3/species");
      RestRequest request = new RestRequest($"narrative/{ sciName.ToLower() }?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee", Method.GET);

      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
    // public static async Task<string> Get(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5004/api");
    //   RestRequest request = new RestRequest($"places/{id}", Method.GET);
    //         request.AddParameter("Authorization", string.Format("Bearer "+ Token.UserToken), ParameterType.HttpHeader);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

  }
}