using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
   public class Variant3 : IVariant
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
        public Variant3()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 0.42; c = 15.85; R = 1.23; vA = 1.11; delta0 = 0.14;
            //a = 0.45; alpha = 67.0; betta = 48.0; f = 0.19; tau = 3.29;
            m = 0.40; c = 17.30; R = 1.30; vA = 1.20; delta0 = 0.11;
            a = 0.50; alpha = 75.0; betta = 45.0; f = 0.19; tau = 3.50;
            path = "3.png";
            path2 = "03.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // формула (1)
            double vK = Math.Sqrt(vA * vA + c * delta0 * delta0 / m
                                - 4.0 * g * delta0 * (sin_a + f * cos_a));
            output += string.Format(" Скорость в точке K = {0:F5} м/с ", vK);
            output += "\r\n";

            // формула (2)
            double vC = Math.Sqrt(vK * vK - 2.0 * g * R * (cos_b - cos_a));
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";

            // формула (3)
            double vB = Math.Sqrt(vK * vK - 2.0 * g * R * (1.0 - cos_a));
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";

            // формула (4)
            double vD = vB - g * f * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";

            // формула (5)
            double N = m * Math.Abs(g * cos_b - vC * vC / R);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";

            return output;
        }

        public double Psi(double a, double t)
        {
            return 2.0 * ((1.0 + a * t) * Math.Log(1.0 + a * t) / a - t);
        }
    }
}
