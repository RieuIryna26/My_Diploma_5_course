using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Variants
{
    public class Variant8 : IVariant
    {
        public double g { get; set; }
        public double pi { get; set; }
        public double m { get; set; }
        public double c { get; set; }
        public double R { get; set; }
        public double vA { get; set; }
        public double delta0 { get; set; }
        public double a { get; set; }
        public double alpha { get; set; }
        public double betta { get; set; }
        public double f { get; set; }
        public double tau { get; set; }
        public string path { get; set; }
        public string path2 { get; set; }
        public Variant8()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 1.77; c = 14.81; R = 1.46; vA = 0.63; delta0 = 0.15;
            //a = 2.36; alpha = 39.0; betta = 55.0; f = 0.14; tau = 1.23;
            m = 2.00; c = 14.00; R = 1.50; vA = 0.50; delta0 = 0.10;
            a = 2.50; alpha = 30.0; betta = 45.0; f = 0.15; tau = 1.20;
            path = "8.png";
            path2 = "08.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // Минимальная скорость в точке A
            double z1 = 4.0 * delta0 * g * (sin_a + f * cos_a) + 2.0 * R * g * (1.0 - cos_a);
            double z2 = c / m * delta0 * delta0 + vA * vA;
            output += string.Format(" Min Скорость в т.A ! z1 = {0:F5}   z2 = {1:F5} ", z1, z2);
            if (z2 <= z1) { output += string.Format(" vA <= min_vA !!!"); goto stop; }
            output += "\r\n";

            // формула (1)
            double vK2 = vA * vA + c / m * delta0 * delta0
                   - 4.0 * g * delta0 * (sin_a + f * cos_a), vK = Math.Sqrt(vK2);
            output += string.Format(" Скорость в точке K = {0:F5} м/с ", vK);
            output += "\r\n";

            double vM = Math.Sqrt(vK2 - 2.0 * R * g * (1.0 - cos_a));
            output += string.Format("     Скорость в т.М = {0:F5} м/с ", vM);
            output += "\r\n";

            // формула (2)
            double vC2 = vK2 + 2.0 * g * R * (sin_b + cos_a), vC = Math.Sqrt(vC2);
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";

            // формула (3)
            double vB2 = vC2 + 2.0 * g * R * (1.0 - sin_b), vB = Math.Sqrt(vB2);
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";

            // формула (4)
            double vD = vB - g * f * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";

            // формула (5)
            double N = m * Math.Abs(vC2 / R + g * sin_b);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";
            

            stop: return output;
        }

        public double Psi(double a, double t)
        {
            double x = 3.0 + a * t;
            return (x - 3.0 * Math.Log(x) - 3.0 + 3.0 * Math.Log(3.0)) / a / a;
        }
    }
}
