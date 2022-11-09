using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class NumberTwo
    {

        public NumberTwo(string[] array)
        {
            var zapros = from lastname in array
                         select (lastname.Replace("А", "").Replace("К", "").Replace("У", "").Replace("Л", "").Replace("О", "").Replace("В", "")
                         .Replace("а", "").Replace("к", "").Replace("у", "").Replace("л", "").Replace("о", "").Replace("в", ""))
                         into ABOBA
                         where (ABOBA.Length > 3)
                         orderby ABOBA.ToUpper()
                         select ABOBA;
            foreach (string lastname in zapros)
                Console.WriteLine(lastname);
        }
    }
}
