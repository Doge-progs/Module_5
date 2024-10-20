using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int count = 7;
            float Sum = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }

            System.Console.WriteLine("Среднее значение {0}", Sum / count);
            System.Console.ReadKey();
        }
    }
}
