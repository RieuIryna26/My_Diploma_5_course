using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    public class Variant4 : IVariant
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
        public Variant4()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 0.88; c = 18.25; R = 0.93; vA = 3.25; delta0 = 0.17;
            //a = 0.22; alpha = 70.0; betta = 25.0; f = 0.13; tau = 0.41;
            m = 0.90; c = 18.50; R = 0.90; vA = 3.00; delta0 = 0.19;
            a = 0.20; alpha = 30.0; betta = 15.0; f = 0.12; tau = 0.50;
            path = "4.png";
            path2 = "04.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // формула (1)
            double vB = Math.Sqrt(vA * vA + c * delta0 * delta0 / m
                                  - 2.0 * g * delta0 * (sin_b + f * cos_b));
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";

            // формула (2)
            double vD = vB - g * (sin_b + f * cos_b) * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";

            // формула (3)
            double vC = Math.Sqrt(vD * vD - 2.0 * g * R * (cos_b + sin_a));
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";

            // формула (4)
            double vK = Math.Sqrt(vD * vD - 4.0 * g * R * cos_b);
            output += string.Format(" Скорость в точке K = {0:F5} м/с ", vK);
            output += "\r\n";

            // формула (5)
            double N = m * Math.Abs(vC * vC / R - g * sin_a);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";

            return output;
        }

        public double Psi(double a, double t)
        {
            double z = 1.0 / (a * a + 1.0);
            return z * (Math.Exp(a * t) * (a * Math.Sin(t) - Math.Cos(t)) + 1.0);
        }
    }
}
