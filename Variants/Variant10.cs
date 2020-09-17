using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    public class Variant10 : IVariant
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
        public Variant10()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 0.87; c = 11.397; R = 0.81; vA = 0.38; delta0 = 0.11;
            //a = -0.82; alpha = 38.0; betta = 69.0; f = 0.25; tau = 0.95;
            m = 1.00; c = 10.00; R = 1.00; vA = 0.20; delta0 = 0.12;
            a = -0.80; alpha = 45.0; betta = 60.0; f = 0.30; tau = 0.90;
            path = "10.png";
            path2 = "010.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double sin_2 = Math.Sin(alpha / 2 * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // Минимальная скорость в точке A
            double z1 = 6.0 * delta0 * g * (cos_b + f * sin_b) + 2.0 * R * g * (1.0 - sin_b);
            double z2 = c / m * delta0 * delta0 + vA * vA;
            output += string.Format(" Min Скорость в т.A ! z1 = {0:F5}   z2 = {1:F5} ", z1, z2);
            if (z2 <= z1) { output += string.Format(" vA <= min_vA !!!"); goto stop; }
            output += "\r\n";

            // формула (1)
            double vK2 = vA * vA + c / m * delta0 * delta0
                   - 6.0 * g * delta0 * (cos_b + f * sin_b), vK = Math.Sqrt(vK2);
            output += string.Format(" Скорость в точке K = {0:F5} м/с ", vK);
            output += "\r\n";

            double vM = Math.Sqrt(vK2 - 2.0 * R * g * (1.0 - sin_b));
            output += string.Format("     Скорость в т.М = {0:F5} м/с ", vM);
            output += "\r\n";

            // формула (2)
            double vC2 = vK2 + 2.0 * g * R * (sin_b - sin_2), vC = Math.Sqrt(vC2);
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";

            // формула (3)
            double vB2 = vC2 + 2.0 * g * R * (sin_2 + sin_a), vB = Math.Sqrt(vB2);
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";

            // формула (4)
            double vD = vB + g * (cos_a - f * sin_a) * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";

            // формула (5)
            double N = m * Math.Abs(vC2 / R - g * sin_2);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";

        stop: return output;
        }

        public double Psi(double a, double t)
        {
            double a2 = 1.0 / a / a;
            return Math.Exp(a * t) * (t / a - a2) + a2;
        }

    }
}
