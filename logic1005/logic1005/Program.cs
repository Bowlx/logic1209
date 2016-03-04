using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logic1005
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int am = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] str_int = new int[str.Length];
            int sum = 0; 
            for (int i = 0; i < am; ++i)
            {
                str_int[i] = int.Parse(str[i]);
                sum += str_int[i];
            }
            

         
            int min = sum;
            int cout = (int)(Math.Pow(2, am - 1) - 1);
            for (int i = 0; i < cout; ++i)
            {
                int num = i + 1;
                int[] a = new int[am];
                int t = 0;
                while  (num != 1)
                {
                    ++t;
                    a[t] = num % 2;
                    num /= 2;
                }
                a[t] = 1;
                int data = 0; 
                for (int k = 0; k < am; k++)
                    if (a[k] == 1)
                        data += str_int[k];
                int data2 = sum - data;
                if (min > Math.Abs(data - data2))
                    min = Math.Abs(data - data2);
            }
            Console.WriteLine(min);
            

        }
    }
}
