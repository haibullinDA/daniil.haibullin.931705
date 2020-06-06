using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class Calc
    {
        public double first_value { get; set; }
        public double second_value { get; set; }
        public string operation { get; set; }
     
        public double toCalc()
        {
            double result;

            switch (operation)
            {
                case "+":
                    result = first_value + second_value;
                    break;
                case "-":
                    result = first_value - second_value;
                    break;
                case "*":
                    result = first_value * second_value;
                    break;
                case "/":
                    if (second_value == 0)
                    {
                        result = -1;
                        break;
                    }
                    result = first_value / second_value;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}
