using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BenchMark challenge exam");

            int[] array = new int[] { 3, 1, 4, 5, 2 };
            array = SortList(array);

            for (int i = 0; i < array.Length ; i++)
            {
                Console.Write(array[i]);
            }

            Console.ReadLine();
        }


        static int[] SortList(int[] array)
        {
            array = array.OrderBy(c => c).ToArray();
            return array;
        }
    }
}
