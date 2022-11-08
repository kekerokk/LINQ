using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Program
    {
        static List<Employee> employees = new List<Employee>() { new Employee("Stepan",34),
        new Employee("Leha",35),
        new Employee("Lena", 65),
        new Employee("Andruha",20),
        new Employee("Valera", 5)};

        static int[] array = { 5, 8, 32, 42, 56, 53 };

        static Random rand = new Random();

        static void Main(string[] args)
        {
            Zadanie1(employees, rand);
            Zadanie3();
        }
        static public void Zadanie1(List<Employee> employees, Random rand)
        {
            var zapros = from emp in employees
                         where emp.age > 18 && emp.age < 60
                         select new
                         {
                             name = emp.name,
                             ID = rand.Next(1000, 9999)
                         }
                 into Card
                         orderby Card.ID descending
                         select Card;
            foreach (var card in zapros)
                Console.WriteLine($"ID:{card.ID} Name:{card.name}\n");
        }
        static public void Zadanie3()
        {
            NumberThree zadanie = new NumberThree(array);
        }

        public struct Employee
        {
            public string name;
            public int age;
            public Employee(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        public struct Card
        {
            public string name;
            public int ID;
            public Card(string name, int ID)
            {
                this.name = name;
                this.ID = ID;
            }
        }
    }
}
