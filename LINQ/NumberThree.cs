using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class NumberThree
    {
        public NumberThree(int[] array)
        {
            var zapros3 = from i in array
                          select (i + array.Max());
            foreach (var p in zapros3)
                Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
