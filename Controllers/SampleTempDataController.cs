﻿using Microsoft.AspNetCore.Mvc;

namespace DataPassingTechniques.Controllers
{
    public class SampleTempDataController : Controller
    {
        public IActionResult GetCountryDetails()
        {
            TempData["My Name"] = "Anusha";
            ViewData["NickName"] = "Poosala";
            //TempData["NickName"] = "Chitti";

            TempData.Keep();
            return RedirectToAction("ContactUs");
        }
        public IActionResult ContactUs()
        {
            ViewData["My Name"] = TempData.Peek("My Name"); //peek stores all the elements in TempData
            
            TempData.Keep();//for specific TempData Key TempData.Keep("CountryName");

            return View();
        }
    }
}
