using DataPassingTechniques.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataPassingTechniques.Controllers
{
    public class SampleViewDataController : Controller
    {
        public IActionResult Index()
        {
            //Synatx for ViewData
            // ViewData is a Dicitonary type and is supported key value pair <string, Object>
            // ViewData["KeyName"] = "Your value/ Object data";

            //Eg:
            ViewData["UserNameKey"] = "Anusha Poosala";

            return View();
        }
        public ActionResult GetCountryDetails()
        {

            ViewData["Heading"] = "Below are the Country Details";

            Country countryObj = new Country();

            countryObj.CountryName = "India";
            countryObj.CountryCapital = "New Delhi";
            countryObj.CountryCode = "In";
            countryObj.CountryPopulation = 141000000;
            countryObj.CountryDescription = "India got the freedom on 1947";

            ViewData["countryObjInfoFromSample"] = countryObj;

            //ViewData will not available for subsequent request 
            ViewData["countryObjInfoFromHome"] = countryObj; //ViewData["countryObjInfo"]; -- it is from HomeController Index method


            return View();
        }

    }
}
