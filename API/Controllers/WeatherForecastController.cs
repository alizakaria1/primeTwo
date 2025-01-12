using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("Food")]
        public IActionResult GetFood()
        {
            List<FoodItem> foodList = new List<FoodItem>()
        {
            new FoodItem { Name = "Lettuce (Iceberg)", Calories = 14, Portion = "100g" },
            new FoodItem { Name = "Cucumber", Calories = 15, Portion = "100g" },
            new FoodItem { Name = "Spinach", Calories = 23, Portion = "100g" },
            new FoodItem { Name = "Carrot", Calories = 41, Portion = "100g" },
            new FoodItem { Name = "Apple", Calories = 52, Portion = "100g" },
            new FoodItem { Name = "Banana", Calories = 89, Portion = "100g" },
            new FoodItem { Name = "Orange", Calories = 47, Portion = "100g" },
            new FoodItem { Name = "Broccoli", Calories = 34, Portion = "100g" },
            new FoodItem { Name = "Cauliflower", Calories = 25, Portion = "100g" },
            new FoodItem { Name = "Mushroom", Calories = 22, Portion = "100g" },
            new FoodItem { Name = "Oatmeal", Calories = 389, Portion = "100g" },
            new FoodItem { Name = "Brown Rice", Calories = 354, Portion = "100g" },
            new FoodItem { Name = "Chicken Breast (Cooked)", Calories = 165, Portion = "100g" },
            new FoodItem { Name = "Salmon (Cooked)", Calories = 206, Portion = "100g" },
            new FoodItem { Name = "Eggs", Calories = 143, Portion = "100g" },
            new FoodItem { Name = "Almonds", Calories = 579, Portion = "100g" },
            new FoodItem { Name = "Walnuts", Calories = 654, Portion = "100g" },
            new FoodItem { Name = "Avocado", Calories = 160, Portion = "100g" },
            new FoodItem { Name = "Cheese (Cheddar)", Calories = 403, Portion = "100g" },
            new FoodItem { Name = "Yogurt (Plain)", Calories = 59, Portion = "100g" },
            new FoodItem { Name = "Butter", Calories = 717, Portion = "100g" },
            new FoodItem { Name = "Olive Oil", Calories = 884, Portion = "100g" },
            new FoodItem { Name = "Coconut Oil", Calories = 869, Portion = "100g" },
            new FoodItem { Name = "Bacon", Calories = 542, Portion = "100g" },
            new FoodItem { Name = "Chocolate (Dark)", Calories = 545, Portion = "100g" },
            new FoodItem { Name = "Potato Chips", Calories = 530, Portion = "100g" },
            new FoodItem { Name = "Sunflower Seeds", Calories = 584, Portion = "100g" },
            new FoodItem { Name = "Macadamia Nuts", Calories = 718, Portion = "100g" },
            new FoodItem { Name = "Peanut Butter", Calories = 588, Portion = "100g" },
            new FoodItem { Name = "Beef (Ground)", Calories = 250, Portion = "100g" }
        };

            return Ok(foodList);
        }
    }
}
