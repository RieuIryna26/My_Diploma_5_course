using System;

namespace Variants
{
    public class Variant1 : IVariant
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
        public Variant1()
        {
            g = 9.81;
            pi = Math.PI / 180.0;
            //m = 1.14; c = 15.20; R = 0.95; vA = 0.25;
            //a = 0.07; alpha = 25.0; betta = 55.0; f = 0.24; tau = 1.82;
            m = 0.90; c = 18.00; R = 1.10; vA = 0.10;
            a = 0.10; alpha = 30.0; betta = 60.0; f = 0.15; tau = 1.30;
            path = "1.png";
            path2 = "01.png";
        }

        public string Calculate()
        {
            string output = "";
            //StreamWriter SW = new StreamWriter("D1_v_01_Volkov.txt");
            //SW.WriteLine("\r\n D1_v_01_Volkov");

            //m = 1.23; c = 10.19; R = 1.06; vA = 0.17;
            //a = 0.12; alpha = 33.0; betta = 48.0; f = 0.21; tau = 1.55;
            //StreamWriter SW = new StreamWriter("D1_v_01_Bondarenko.txt");
            //SW.WriteLine("\r\n D1_v_01_Bondarenko");

            //m = 1.19; c = 13.77; R = 1.14; vA = 0.21;
            //a = 0.09; alpha = 27.0; betta = 50.0; f = 0.23; tau = 1.61;
            //StreamWriter SW = new StreamWriter("D1_v_01_Liutaya.txt");
            //SW.WriteLine("\r\n D1_v_01_Liutaya");

            double cos_a = Math.Cos(alpha * pi), sin_a = Math.Sin(alpha * pi);
            double cos_b = Math.Cos(betta * pi), sin_b = Math.Sin(betta * pi);
            c = 100 * c; // приведение к размерности [ Н / м ]

            // формула (1)
            double vB = vA + g * (cos_b - f * sin_b) * tau + Psi(a, tau) / m;
            output += string.Format(" Скорость в точке B = {0:F5} м/с ", vB);
            output += "\r\n";
            // формула (2)
            double vC = Math.Sqrt(vB * vB + 2.0 * g * R * (sin_b - sin_a));
            output += string.Format(" Скорость в точке С = {0:F5} м/с ", vC);
            output += "\r\n";
            // формула (3)
            double vD = Math.Sqrt(vB * vB + 2.0 * g * R * sin_b);
            output += string.Format(" Скорость в точке D = {0:F5} м/с ", vD);
            output += "\r\n";
            // формула (4)
            double z = m * g;
            double delta = (Math.Sqrt(z * z + c * m * vD * vD) + z) / c;
            output += string.Format(" Деформация пружины = {0:F5} м ", delta);
            output += "\r\n";
            // формула (5)
            double N = m * Math.Abs(g * sin_a - vC * vC / R);
            output += string.Format(" Давление в точке С = {0:F5} Н \r\n", N);
            output += "\r\n";
            return output;
        }

        public double Psi(double a, double t)
        {
            return Math.Sin(a + t) * Math.Sin(t);
        }
    }
}
