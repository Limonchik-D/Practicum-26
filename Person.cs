using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_26
{
    class Person
    {
        private int age; //Возраст человека
        private static int retirementAge; //Пенсионный возраст
        public static int RetirementAge //Проверка на ограничение возаста до 100 лет
        {
            get
            {
                return retirementAge;
            }
            set
            {
                if(value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Возраст должен быть в диапазоне от 1 до 100");
                }   
                retirementAge = value;
            }
        }

        public Person()
        {
            age = 20;
            RetirementAge = 60;

        }
        public Person(int age, int retirementAge)
        {
            this.age = age;
            RetirementAge = retirementAge;
        }
        public string CheckRetirementStatus()
        {
            if (age >= retirementAge)
            {
                return "Человек уже на пенсии";
            }
            else
            {
                int result = retirementAge - age;
                return $"До пенсии осталось: {result} лет" ;
            }


        }
        public void Output()
        {
            Console.WriteLine( $"Возраст: {age}, Пенсионный возраст: {retirementAge}");
        }

    }
}
