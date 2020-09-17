using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    public class Variant6 : IVariant
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
        public Variant6()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 0.96; c = 17.53; R = 0.85; vA = 2.47; delta0 = 0.21;
            //a = 1.19; alpha = 22.0; betta = 57.0; f = 0.16; tau = 0.81;
            m = 1.00; c = 17.00; R = 1.00; vA = 2.00; delta0 = 0.20;
            a = 1.10; alpha = 30.0; betta = 60.0; f = 0.12; tau = 1.00;
            path = "6.png";
            path2 = "06.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // формула (1)
            double vK2 = vA * vA + c / m * delta0 * delta0
                   + 8.0 * g * delta0 * (sin_a - f * cos_a), vK = Math.Sqrt(vK2);
            output += string.Format(" Скорость в точке K = {0:F5} м/с ", vK);
            output += "\r\n";

            // Минимальная скорость в точке K
            double min_vK = Math.Sqrt(2.0 * R * (1.0 + 2.0 * cos_a) * g);
            output += string.Format(" Min Скорость в т.K = {0:F5} м/с ", min_vK);
            if (vK <= min_vK) { output += string.Format(" vK <= min_vK !!!"); goto stop; }
            output += "\r\n";

            // формула (2)
            double vC2 = vK2 - 2.0 * g * R * (sin_b + 2.0 * cos_a), vC = Math.Sqrt(vC2);
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";

            // формула (3)
            double vB2 = vC2 + 2.0 * g * R * (sin_b - cos_a), vB = Math.Sqrt(vB2);
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";

            // формула (4)
            double vD = vB + g * (sin_a - f * cos_a) * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";

            // формула (5)
            double N = m * Math.Abs(vC2 / R - g * sin_b);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";

            stop: return output;
        }

        public double Psi(double a, double t)
        {
            double a2 = a * a;
            return t / Math.Sqrt(a2 + t * t) / a2;
        }
    }
}
