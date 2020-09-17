using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    public class Variant7 : IVariant
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
        public Variant7()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 1.10; c = 12.27; R = 1.44; vA = 0.51; delta0 = 0.16;
            //a = -0.91; alpha = 75.0; betta = 32.0; f = 0.14; tau = 0.58;
            m = 1.00; c = 10.00; R = 1.00; vA = 0.50; delta0 = 0.10;
            a = -1.00; alpha = 60.0; betta = 30.0; f = 0.20; tau = 0.50;
            path = "7.png";
            path2 = "07.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // формула (1)
            double vK2 = vA * vA + c / m * delta0 * delta0
                   - 6.0 * g * delta0 * f, vK = Math.Sqrt(vK2);
            output += string.Format(" Скорость в точке K = {0:F5} м/с ", vK);
            output += "\r\n";

            // формула (2)
            double vC2 = vK2 + 2.0 * g * R * (1.0 + cos_a), vC = Math.Sqrt(vC2);
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";

            // формула (3)
            double vB2 = vC2 + 2.0 * g * R * (cos_b - cos_a), vB = Math.Sqrt(vB2);
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";

            // формула (4)
            double vD = vB - g * (sin_b + f * cos_b) * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";

            // формула (5)
            double N = m * Math.Abs(vC2 / R + g * cos_a);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";          

            return output;
        }

        public double Psi(double a, double t)
        {
            return 2.0 * (Math.Cos(a) - Math.Cos(a + 3.0 * t)) / 3.0;
        }
    }
}
