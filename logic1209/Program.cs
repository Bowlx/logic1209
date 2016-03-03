using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic1209
{
    class Program
    {
       static bool isOne(int n)
        {

            double ans = (Math.Sqrt((double)8 * n + 1) - 1) / 2.0;
            ans = ans + 1e-7;
            long r = (long)ans;
            if ((r * (r + 1)) / 2 == n) return true;
            return false;


        }
        static void Main(string[] args)
        {
            int am = int.Parse(Console.ReadLine());
            
            int[] str_int = new int[am];
            for (int i = 0; i < am; i++)
            {
                str_int[i]= int.Parse(Console.ReadLine());


            }
            for (int i = 0; i < am; ++i)
            {
              if (isOne(str_int[i]-1)==true) Console.Write("1 ");
              else
              {
                    Console.Write("0 ");
                }
            }
        }
    }
}
