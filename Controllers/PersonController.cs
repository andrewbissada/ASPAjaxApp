using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyASPajaxApp.Models;


namespace MyASPajaxApp.Controllers
{
   
public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetPeople()
        {
            List<Person> people = new List<Person> {
                new Person { State = "NV", Name = "Alice", Age = 25 },
                new Person { State = "TX", Name = "Bob", Age = 30 },
                new Person { State = "SC", Name = "Charlie", Age = 35 }
            };
            return Json(people);
        }
    }
}
