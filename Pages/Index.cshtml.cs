using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PanasonicWeather.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<City> cityList = new List<City>();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            //Add Cities to model. In a real world example I would expect a call to a DB table.
            cityList.Add(new City("Columbus, GA", "United States", "Panasonic Energy Corporation of America",32.5078, -84.8850));
            cityList.Add(new City("Osaka", "Japan", "Head Office Function, R&D, MORIGUCHI Factory", 34.6937, 135.5023));
            cityList.Add(new City("Sparks, NV", "United States", "Panasonic Energy of North America", 39.5358,- 119.4399));
            cityList.Add(new City("Pithampur", "India", " Panasonic Energy India Co., Ltd.", 22.6353, 75.5926));
        }
        public void OnGet()
        {

        }
    }

    public class City
    {
        public String name;
        public String country;
        public String desc;
        public double longitude;
        public double latitude;

        public City(String cityName, String cityCountry, String cityDesc, double cityLat, double cityLng)
        {
            name = cityName;
            country = cityCountry;
            desc = cityDesc;
            longitude = cityLng;
            latitude = cityLat;
        }
    }
}