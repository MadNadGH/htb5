using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 4, b = 8, c = 321;

            Class16 class16 = new Class16(a, b, c);
            Console.WriteLine(class16.Answer());
           
        }
    }
}
