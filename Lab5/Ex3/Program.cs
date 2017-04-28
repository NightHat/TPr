using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_k
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цену 1 кг яблок: ");
            int g = int.Parse(Console.ReadLine());
            int h = 100;
            for (int i = 0; i < 4; i++)
            { 
                int c = g * h;
                Console.WriteLine("Цена за " + h + " кг = " + c + " грн");
                h = h - 25;
            }
            Console.WriteLine("Цена за 1 кг = "+ g + " грн");

            Console.ReadLine();
        }
    }
}
