using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class mylist
    {
        public List<int> values;

        public mylist(int value1, int value2)
        {
            values = new List<int> { };
            values.Add(value1);
            values.Add(value2);            
        }
    }
}
