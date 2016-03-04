using System;
using System.Linq;

namespace logic1025
{
    class Program
    {
        static void Main(string[] args)
        {
            double Result = 0;
            int am = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] array = new int[str.Length];
            for (int i = 0; i < am; ++i)
            
                array[i] = int.Parse(str[i]);
                
            

            Array.Sort(array);
            double num = Math.Ceiling(array.Length / 2.0);

            for (int i = 0; i < num; ++i)
            {
                Result += (Math.Ceiling(array[i] / 2.0));
            }
            Console.WriteLine(Result);
        }
    }
}