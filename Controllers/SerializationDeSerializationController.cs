using DataPassingTechniques.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Text.Json;

namespace DataPassingTechniques.Controllers
{
    public class SerializationDeSerializationController : Controller
    {
        public IActionResult GetCountryDetailsJson()
        {
            Country countryObj=new Country();
            countryObj.CountryCode = "IN";
            countryObj.CountryDescription = "India";
            countryObj.CountryName = "Bharath";
            countryObj.CountryCapital = "Delhi";
            countryObj.CountryPopulation = 14300000000000;

            CountryCurrency countryCurrencyObj = new CountryCurrency();
            countryCurrencyObj.CountryCurrencyValue = 82;
            countryCurrencyObj.CountryCurrencyName = "Rupee";
            countryCurrencyObj.CountryCurrencyCode = "INR";

            CountryIncomeSources countryIncomeSourcesObj = new CountryIncomeSources();
            countryIncomeSourcesObj.Agriculture = "55";
            countryIncomeSourcesObj.ITExports = "20";
            countryIncomeSourcesObj.ITTax = "15";
            countryIncomeSourcesObj.Tourism = "10";

            CountryViewModel countryViewModelObj = new CountryViewModel();
            countryViewModelObj.country=countryObj;
            countryViewModelObj.CountryCurrency = countryCurrencyObj;
            countryViewModelObj.CountryIncomeSources = countryIncomeSourcesObj;

            string countryViewModelJson= JsonSerializer.Serialize(countryViewModelObj);
            TempData["countryDetailsJson"]=countryViewModelJson;

            return View();
            //return Content(countryViewModelJson);
        }
    }
}
