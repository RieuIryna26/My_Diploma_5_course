using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variants
{
   public class Variant5 : IVariant
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
        public Variant5()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 0.86; c = 12.48; R = 1.21; vA = 5.77;
            //a = 0.25; alpha = 28.0; betta = 71.0; f = 0.12; tau = 1.24;
            m = 1.00; c = 12.00; R = 1.30; vA = 5.20;
            a = 0.25; alpha = 30.0; betta = 75.0; f = 0.10; tau = 1.50;
            path = "5.png";
            path2 = "05.png";
        }

        public string Calculate()
        {
            string output = "";
            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // Минимальная скорость в точке А
            double min_vA = Math.Sqrt(2.0 * g * R);
            output += string.Format(" Min Скорость в т.A = {0:F5} м/с ", min_vA);
            if (vA <= min_vA) { output += string.Format(" vA <= min_vA !!!"); goto stop; }
            output += "\r\n";

            // формула (1)
            double vC2 = vA * vA - 2.0 * g * R * cos_b, vC = Math.Sqrt(vC2);
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";

            // формула (2)
            double vB = Math.Sqrt(vA * vA + 2.0 * g * R * cos_a);
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";

            // формула (3)
            double vD = vB + g * (sin_a - f * cos_a) * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";

            // формула (4)
            double z = g * (sin_a - f * cos_a), cm = c / m;
            double delta1 = (z + Math.Sqrt(z * z + cm * vD * vD)) / cm;
            output += string.Format(" Деформация пружины = {0:F5} м ", delta1);
            output += "\r\n";

            // формула (5)
            double N = m * Math.Abs(vC2 / R - g * cos_b);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";
            

          stop:  return output;
        }

        public double Psi(double a, double t)
        {
            double ta = t / a;
            return 0.25 * Math.Log(1.0 + ta * ta * ta * ta);
        }
    }
}
