using System;
using System.IO;


namespace Variants
{
    public class Variant0 : IVariant
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

    public Variant0()
        {
            g = 9.81;     // входные параметры задания
            m = 1.5;
            a = 2.0;
            c = 10.0;  // приведение к размерности [ Н / м ]
            vA = 0.2;
            f = 0.17;
            R = 0.8;
            alpha = 30.0;
            tau = 0.9;
            path = "0.png";
            path2 = "00.png";
        }

        public string Calculate()
        {
            string output = "";
            
            double c = 100 * this.c;
            double cos_a = Math.Cos(alpha * Math.PI / 180.0);
            double sin_a = Math.Sin(alpha * Math.PI / 180.0);

            // формула (Д3.5)
            double vC = Math.Sqrt(vA * vA + 4.0 * g * R * (2.0 * cos_a + sin_a));

            // формула (Д3.6)
            double vB = Math.Sqrt(vA * vA + 12.0 * g * R * cos_a);

            // формула (Д3.10)
            double vD = vB - g * (sin_a + f * cos_a) * tau + Psi(a, tau) / m;

            // формула (Д3.11)
            double z = m * g * (sin_a + f * cos_a);
            double delta = (Math.Sqrt(z * z + c * m * vD * vD) - z) / c;

            // формула (Д3.12)
            double N = m * (vC * vC / R / 2.0 + g * sin_a);
            

            string txt = string.Format(" Скорость в точке С = {0:F3} м/с ", vC);
            output += txt; output += "\r\n";
            txt = string.Format(" Скорость в точке B = {0:F3} м/с ", vB);
            output += txt; output += "\r\n";
            txt = string.Format(" Скорость в точке D = {0:F3} м/с ", vD);
            output += txt; output += "\r\n";
            txt = string.Format(" Деформация пружины = {0:F3} м ", delta);
            output += txt; output += "\r\n";
            txt = string.Format(" Давление в точке С = {0:F3} Н \r\n", N);
            output += txt; output += "\r\n";

            return output;
            
        }

        public double Psi(double a, double t)
        {
            double sqrt = Math.Sqrt(a * a + t * t);
            double ln = Math.Log(Math.Abs(t + sqrt) / Math.Abs(a));
            return (t * sqrt + a * a * ln) / 2.0;
        }
    }
}
