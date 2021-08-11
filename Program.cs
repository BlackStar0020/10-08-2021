 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            double a = double.Parse(Console.ReadLine());
             if (a > 500)
             {
                 double sk = (a * 3) / 100, stoimost3 = a - sk;
                 Console.WriteLine($"{stoimost3} ");

             }
             else if (a > 1000)
             {
                 double sk = (a * 5) / 100, stoimost5 = a - sk;
                 Console.WriteLine($"{stoimost5} ");

             }else
             {
                 Console.WriteLine($"{a}");
             }
             Console.ReadKey();
            
            //2
             double a = double.Parse(Console.ReadLine());
             double b = double.Parse(Console.ReadLine());
             double c = double.Parse(Console.ReadLine());
             double d = double.Parse(Console.ReadLine());
             if (!(a < b && b < c && c < d))
             {
                 double sum1 = Math.Min(a, b), sum2 = Math.Min(c, d), sum3 = Math.Min(sum1, sum2);
                 Console.WriteLine($"{sum3}");
             } 
             else if (a == b && b == c   && c == d)
             {
                 double proiz = a * b * c * d;
                 Console.WriteLine($"{proiz}");
             }
             else
             {
                 Console.WriteLine("Числа расположены по возрастанию");
             }
             Console.ReadKey();
            //3
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if(a == b && b == c && c == a)
            {
                Console.WriteLine($"a={a}, b={b} c={c}");
            }
           else if (a>=b && a >= c && b>=c)
            {
                Console.WriteLine($"a={a}, b={b} c={c}") ;
            }
           else if(b>=a && b >= c && a>=c)
            {
                Console.WriteLine($"a={b}, b={a} c={c}");
            }
           else if(b>=c && b >= a && c>=a)
            {
                Console.WriteLine($"a={b}, b={c} c={a}");
            }
            else if(c>=b && c>=a && b >= a)
            {
                Console.WriteLine($"a={c}, b={b} c={a}");
            }
            else if(c >= b && c >= a && a >= b)
            {
                Console.WriteLine($"a={c}, b={a} c={b}");
            }
            Console.ReadKey();
        }
    }
}
