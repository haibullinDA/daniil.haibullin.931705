using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Services
{
    public class HTMLSender : IMessageSender
    {
        public int[] GetArr()
        {
            Random rand = new Random();
            int value1 = rand.Next(0, 10);
            int value2 = rand.Next(0, 10);
            
            int[] values = new int[] {value1, value2};
            return values;
        }
    }
}
