using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ASPAssignment1.Controllers
{
    public class GuessingGameController : Controller
    {
        [HttpGet]
        public IActionResult GuessingNumber()
        {
            Random randNum = new Random();
            int randNumber = randNum.Next(1,100);
            // seting values in the session key
            HttpContext.Session.SetString("gussNumberSession", randNumber.ToString());
            
            return View();
        }
        [HttpPost]
        public IActionResult GuessingNumber(int textBoxintData)
        {
            //geting values from session key
            int randNumber = Convert.ToInt32(HttpContext.Session.GetString("gussNumberSession"));
            if(textBoxintData == randNumber)
            {
                ViewBag.Message = "You won the game";
            }
            else if(textBoxintData > randNumber)
            {
                ViewBag.Message = "Your guss is too high";
            }
            else if(textBoxintData < randNumber)
            {
                ViewBag.Message = "Your guss is too low";
            }

            return View();
            
        }

    }
}
