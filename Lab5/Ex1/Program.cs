using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_k_
{
    class Program
    {
        static void Main(string[] args)
        {
            int f, s;
            Console.WriteLine("Проверка знаний по истории архитектуры!");
            Console.WriteLine("Кто является основоположником функционализма в архитектуре?");
            Console.WriteLine("1. Винни Пух 2. Гропиус Вальтер 3. Наруто");
            f = Convert.ToInt32(Console.ReadLine());
            if (f == 2)
            {
                Console.WriteLine("Правильный ответ!");
                Console.WriteLine();
                Console.WriteLine("Cледующий вопрос:");
                Console.WriteLine("Кто написал книгу «Дизайн для реального мира»?");
                Console.WriteLine("1. Виктор Папанек 2. Мефистофель 3. Пеппи Длинныйчулок");
                s = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    Console.WriteLine("Правильный ответ!");
                    Console.WriteLine("Вы отлично знаете историю архитектуры! Браво!");
                }
                else
                {
                    Console.WriteLine("Ответ неверный! Жаль, но вы проиграли :(");
                }

            }
            else
            {
                Console.WriteLine("Ответ неверный! Жаль, но вы проиграли :(");
            }
                Console.ReadLine();
         }
     }
}
   

