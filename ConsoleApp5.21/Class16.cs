using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5._21
{
    public class Class16
    {
        public double X;
        public double Y;
        public double Z;

        public Class16(double a, double b, double c)
        {
            X = a;
            Y = b;
            Z = c;
        }

        public bool Answer()
        {
            return (X % 5 == 0 && Y % 5 != 0 && Z % 5 != 0) ||
                   (Y % 5 == 0 && X % 5 != 0 && Z % 5 != 0) ||
                   (Z % 5 == 0 && Y % 5 != 0 && X % 5 != 0);
        }
    }
}
