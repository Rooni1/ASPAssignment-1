using ASPAssignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment2.Controllers
{
    public class DoctorController : Controller
    {
        Utility myutility = new Utility();
        public IActionResult Temchecker(float textBoxfloatData)
        {
            if(textBoxfloatData != 0)
            {
                ViewBag.Message = myutility.Checkfever(textBoxfloatData);

            }
            return View();
           
        }
         
        
        

    }
}
