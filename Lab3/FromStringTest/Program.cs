using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromStringTest
{
    class FromString
    {
        private string name;
        private string age;
        private string salary;
        public void Data()
        {
            Console.WriteLine("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            age = Console.ReadLine();
            Console.WriteLine("Введите вашу зарплату: ");
            salary = Console.ReadLine();
            Console.WriteLine();
        }

        public void FromStringTest()
        {
            Convert.ToInt32(age);
            Convert.ToDouble(salary);
        }
        public void WhoIsWho()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Зарплата: " + salary);
        }
    }
    class Program
    {

        static void Main(string[] args)
            {
            FromString obj = new FromString();
            obj.Data();
            obj.FromStringTest();
            obj.WhoIsWho();
            Console.ReadLine();
            }
        }
    
}

