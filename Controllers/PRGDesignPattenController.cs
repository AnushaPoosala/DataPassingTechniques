using DataPassingTechniques.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataPassingTechniques.Controllers
{
    public class PRGDesignPattenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitCountryData(Country country) 
        {
            if(ModelState.IsValid)
            {
                TempData["IsCountryDataSaved"] = "Country data is saved successfully";
                return RedirectToAction(nameof(Success));
            }
            return View("Index", country);
        }

        public IActionResult Success() 
        {
            return View();
        }
    }
}
