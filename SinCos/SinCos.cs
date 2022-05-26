using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinCos
{
    public class SiCo
    {
        public double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public SiCo()
        {
            x = 0;
        }
        public SiCo(double a)
        {
            x = a;
        }
        public override string ToString()
        {
            return $"{x}";
        }
        public double Calc()
        {
            return Math.Sin(X) + Math.Cos(2 * X);
        }
    }
}
