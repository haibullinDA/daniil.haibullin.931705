using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab2.Models;

namespace Lab2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManualParsingInSingleAction()
        {
            return View();
        }

        public IActionResult ManualParsingInSeparateActions()
        {
            return View();
        }

        public IActionResult ModelBindingParametrs()
        {
            return View();
        }

        public IActionResult ModelBindingSeparateModel()
        {
            return View();
        }

        public IActionResult Count1()
        {
            if (Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                int value1 = Convert.ToInt32(this.Request.Form["input1"]);
                int value2 = Convert.ToInt32(this.Request.Form["input2"]);
                string operation = this.Request.Form["operation"];

                double result;

                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;
                    case "/":
                        if (value2 == 0)
                            return View("ZeroErrorCalc");
                        result = value1 / value2;
                        break;
                    default:
                        result = 0;
                        break;
                }

                ViewBag.input1 = value1;
                ViewBag.input2 = value2;
                ViewBag.operation = operation;
                ViewBag.result = result;

            }

            return View("Result");
        }

        [HttpPost, ActionName("Count2")]
        public IActionResult Count2Post()
        {
            if (Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase))
            {
                int value1 = Convert.ToInt32(this.Request.Form["input1"]);
                int value2 = Convert.ToInt32(this.Request.Form["input2"]);
                string operation = this.Request.Form["operation"];

                double result;

                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;
                    case "/":
                        if (value2 == 0)
                            return View("ZeroErrorCalc");
                        result = value1 / value2;
                        break;
                    default:
                        result = 0;
                        break;
                }

                ViewBag.input1 = value1;
                ViewBag.input2 = value2;
                ViewBag.operation = operation;
                ViewBag.result = result;

            }

            return View("Result");
        }

        [HttpPost]
        public IActionResult Count3(int input1, int input2, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = input1 + input2;
                    break;
                case "-":
                    result = input1 - input2;
                    break;
                case "*":
                    result = input1 * input2;
                    break;
                case "/":
                    if (input2 == 0)
                        return View("ZeroErrorCalc");
                    result = input1 / input2;
                    break;
                default:
                    result = 0;
                    break;
            }

            ViewBag.input1 = input1;
            ViewBag.input2 = input2;
            ViewBag.operation = operation;
            ViewBag.result = result;

            return View("Result");
        }


        [HttpPost]
        public IActionResult Count4(Calc calc)
        {

            ViewBag.input1 = calc.first_value;
            ViewBag.input2 = calc.second_value;
            ViewBag.operation = calc.operation;
            ViewBag.result = calc.toCalc();
            if (ViewBag.result == -1)
                return View("ZeroErrorCalc");
            return View("Result");
        }
    }
}