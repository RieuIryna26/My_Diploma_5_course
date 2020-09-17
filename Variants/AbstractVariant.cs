using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    public abstract class AbstractVariant
    {
        public double g;
        public double pi;
        public double m;
        public double c;
        public double R;
        public double vA;
        public double delta0;
        public double a;
        public double alpha;
        public double betta;
        public double f;
        public double tau;

        public abstract string Calculate();
        public abstract double Psi(double a, double t);
    }
}
