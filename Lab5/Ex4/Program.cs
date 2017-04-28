using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_k
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 0;
            int[] MyArr = new int[7];
            Console.WriteLine("Введите элементы масива: ");
            for (int i = 0; i < MyArr.Length; i++)
            {
                MyArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите число массива ");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < MyArr.Length; i++)
            {
                if (MyArr[i] == c)
                {
                    w = w + 1;
                }
            }
            Console.WriteLine("Это число повторяется " + w + " раз(а)!");
            Console.ReadLine();
        }
    }
}
