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
    public static async Task<string> GetDetails(string sciName)
    {
      RestClient client = new RestClient("http://apiv3.iucnredlist.org/api/v3/country/getspecies");
      RestRequest request = new RestRequest($"{sciName}?token=9bb4facb6d23f48efbf424bb05c0c1ef1cf6f468393bc745d42179ac4aca5fee", Method.GET);

      var response = await client.ExecuteTaskAsync(request);
      Console.WriteLine("URL:" + response.ResponseUri);
      return response.Content;
    }
  }
}