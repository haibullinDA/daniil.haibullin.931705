using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using System.Diagnostics;

namespace Lab3.Controllers
{
    public class QuizController : Controller
    {
        static Result result = new Result();
        static Random rand = new Random();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quiz()
        {
            if (ModelState.IsValid)
            {
                ViewBag.numb1 = rand.Next(10);
                ViewBag.numb2 = rand.Next(10);
                return View();
            }

            return View();
        }

        public IActionResult QuizResult()
        {
            if (ModelState.IsValid)
            {
                ViewBag.ListResult = result.ListResult;
                ViewBag.RightAnswersCount = result.RightAnswersCount;
                ViewBag.AnswersCount = result.AnswersCount;
                return View();
            }

            return View();
        }

        public void QuizLogic(string value1, string value2, string answer)
        {
            int _value1 = Convert.ToInt32(value1);
            int _value2 = Convert.ToInt32(value2);
            int _answer = Convert.ToInt32(answer);

            result.ListResult.Add(_value1 + " + " + _value2 + " = " + _answer);
            result.AnswersCount++;

            if (_value1 + _value2 == _answer)
            {
                result.RightAnswersCount++;
            }

            ViewBag.numb1 = rand.Next(10);
            ViewBag.numb2 = rand.Next(10);
        }

        [HttpPost]
        public IActionResult Next(string value1, string value2, string answer)
        {
            QuizLogic(value1, value2, answer);
            return View("quiz");
        }

        [HttpPost]
        public IActionResult Finish(string value1, string value2, string answer)
        {
            QuizLogic(value1, value2, answer);
            ViewBag.ListResult = result.ListResult;
            ViewBag.RightAnswersCount = result.RightAnswersCount;
            ViewBag.AnswersCount = result.AnswersCount;
            return View("quizResult");
        }
    }
}