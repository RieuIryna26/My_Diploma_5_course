using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
    public class Variant9 : IVariant
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
        public Variant9()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 1.32; c = 8.93; R = 0.69; vA = 0.23;
            //a = 0.34; alpha = 38.0; betta = 54.0; f = 0.09; tau = 0.54;
            m = 1.00; c = 8.00; R = 0.50; vA = 0.20;
            a = 0.25; alpha = 30.0; betta = 45.0; f = 0.05; tau = 0.50;
            path = "9.png";
            path2 = "09.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // формула (1)
            double vC2 = vA * vA + 4.0 * g * R * (2.0 - cos_b), vC = Math.Sqrt(vC2);
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";

            // формула (2)
            double vB = Math.Sqrt(vA * vA + 12.0 * g * R);
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";

            // формула (3)
            double vD = vB - g * (sin_a + f * cos_a) * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";

            // формула (4)
            double z = g * (sin_a + f * cos_a), cm = c / m;
            double delta = (-z + Math.Sqrt(z * z + cm * vD * vD)) / cm;
            output += string.Format(" Деформация пружины = {0:F5} м ", delta);
            output += "\r\n";

            // формула (5)
            double N = m * Math.Abs(vC2 / R - g * cos_b);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";
          

            return output;
        }

        public double Psi(double a, double t)
        {
            double ta = Math.Sqrt(a * a + t * t);
            return t * Math.Log(t + ta) - ta - Math.Abs(a);
        }
    }
}
