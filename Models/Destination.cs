using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelApiMVC.Models
{
  public class Destination
  {
    public string Country { get; set; }
    public string City { get; set; }
    public int Rating { get; set; }

    public static List<Destination> GetDestinations()
    {
      var apiCallTask = ApiHelper.ApiCall();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

      return destinationList;
    }
  }

}