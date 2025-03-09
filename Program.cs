
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Output();
            Console.WriteLine(person.CheckRetirementStatus());
            Console.WriteLine();

            Person person1 = new Person(50, 65);
            person1.Output();
            Console.WriteLine(person1.CheckRetirementStatus());
            Console.WriteLine();

            Person person2 = new Person();
            Person.RetirementAge = 70;
            person2.Output();
            Console.WriteLine(person2.CheckRetirementStatus());
            
            Console.ReadKey();

        }
    }
}
