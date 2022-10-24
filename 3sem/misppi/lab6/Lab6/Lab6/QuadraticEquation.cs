namespace Lab6;

public class QuadraticEquation
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double D { get => B * B - 4 * A * C; }

    public QuadraticEquation() { A = 1; B = 1; C = 1; }
    public QuadraticEquation(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public virtual string Solve()
    {
        if (D < 0) return "Нет корней";
        if (D == 0) return $"{-B/(2 * A)}";

        double x1 = (-B + Math.Sqrt(D)) / 2 * A;
        double x2 = (-B - Math.Sqrt(D)) / 2 * A;
        return $"{x1}; {x2}";
    }
    public override string ToString() => Solve();
}
