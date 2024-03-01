using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex005
{
    internal class Area
    {
        public double Retangulo(double l, double a)
        {
            return l * a;
        }
        public double Circulo(double r)
        {
            return 3.14 * (r * r);
        }
        public double Triangulo(double b, double a)
        {
            return (b * a) / 2;
        }
    }
}
