namespace Variants
{
    public interface IVariant
    {
        double g { get; set; }
        double pi { get; set; }
        double m { get; set; }
        double c { get; set; }
        double R { get; set; }
        double vA { get; set; }
        double delta0 { get; set; }
        double a { get; set; }
        double alpha { get; set; }
        double betta { get; set; }
        double f { get; set; }
        double tau { get; set; }
        string path { get; set; }
        string path2 { get; set; }

        string Calculate();
        double Psi(double a, double t);
    }
}
