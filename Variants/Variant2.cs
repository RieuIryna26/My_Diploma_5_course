using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    public class Variant2 : IVariant
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
        public Variant2()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 0.88; c = 26.05; R = 1.71; vA = 0.18; delta0 = 0.14;
            //a = 0.63; alpha = 22.0; betta = 65.0; f = 0.15; tau = 0.63;
            m = 0.70; c = 31.00; R = 1.80; vA = 0.00; delta0 = 0.14;
            a = 0.60; alpha = 30.0; betta = 60.0; f = 0.05; tau = 0.70;
            path = "2.png";
            path2 = "02.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double sin_2 = Math.Sin(alpha / 2 * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // формула (1)
            double vK = Math.Sqrt(vA * vA + c * delta0 * delta0 / m
                                                 - 2.0 * f * g * delta0);
            output += string.Format(" Скорость в точке K = {0:F5} м/с ", vK);
            output += "\r\n";
            // формула (2)
            double vC = Math.Sqrt(vK * vK - 2.0 * g * R * (1.0 - cos_a));
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";
            // формула (3)
            double vB = Math.Sqrt(vK * vK - 2.0 * g * R * (1.0 - cos_b));
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";
            // формула (4)
            double vD = vB - g * (sin_b + f * cos_b) * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";
            // формула (5)
            double N = m * Math.Abs(g * cos_a + vC * vC / R);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";
            
            return output;
        }

        public double Psi(double a, double t)
        {
            return 4.0 * ((Math.Sin(t * 3.0 - a) + Math.Sin(a)) / 3.0);
        }
    }
}
