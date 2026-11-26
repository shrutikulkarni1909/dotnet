using Microsoft.AspNetCore.Mvc;

namespace CatalogAPI.Controllers;
//attribute

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
   
    [HttpGet(Name = "GetTemperatures")] 
    public List<int> GetTodaysTemperatures()
    {
        List<int> numbers= new List<int>();
        numbers.Add(23);
        numbers.Add(26);
        numbers.Add(35);
        return numbers;

    }
   
}
