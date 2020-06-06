using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab1.Models;
using Lab1.Services;

namespace Lab1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UsingModelCalc()
        {
            Random rand = new Random();
            int value1 = rand.Next(0, 10);
            int value2 = rand.Next(0, 10);

            mylist l = new mylist(value1, value2);

            if (value2 != 0)
            {
                return View(l);
            }
            else
            {
                return View("ZeroErrorCalc");
            }
        }
    
        public IActionResult ViewDataCalc()
        {
        
            Random rand = new Random();
            int value1 = rand.Next(0, 10);
            int value2 = rand.Next(0, 10);

            ViewData["Value1"] = value1;
            ViewData["Value2"] = value2;

            if (value2 != 0)
            {
                return View("ViewDataCalc");
            }
            else
            {
                return View("ZeroErrorCalc");
            }
        }

        public IActionResult ViewBagCalc()
        {
            Random rand = new Random();
            int value1 = rand.Next(0, 10);
            int value2 = rand.Next(0, 10);

            ViewBag.Value1 = value1;
            ViewBag.Value2 = value2;

            if (value2 != 0)
            {
                return View("ViewBagCalc");
            }
            else
            {
                return View("ZeroErrorCalc");
            }
        }

        
        public IActionResult ServiceInjectionCalc([FromServices] IMessageSender messageSender)
        {
            int[] arr = messageSender.GetArr();
            if (arr[1] != 0)
            {
                return View(arr);
            }
            else
            {
                return View("ZeroErrorCalc");
            }
        }
        

    }

    public class TwoNumb
    {
        public int value1 { get; set; }
        public int value2 { get; set; }
    }

}