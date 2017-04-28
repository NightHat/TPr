using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_k
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте номер месяца: ");
            int m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    Console.WriteLine("В этом месяце 31 день");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:

                    Console.WriteLine("В этом месяце 30 дней");
                    break;

                case 2:

                    Console.WriteLine("В этом месяце 28 дней");
                    break;

            }
            Console.ReadLine();
        
        }
    }
}
