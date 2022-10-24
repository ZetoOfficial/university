namespace Lab6;

public class BiquadraticEquation : QuadraticEquation
{
    public BiquadraticEquation() { A = 1; B = 1; C = 1; }
    public BiquadraticEquation (double A, double B, double C) : base(A, B, C) { }
    public override string Solve()
    {
        if (D < 0) return "Нет корней";
        if (D == 0) return $"x1={Math.Sqrt(-C / B)}; x2={-Math.Sqrt(-C / B)}";

        var d1 = (-B + Math.Sqrt(D)) / (2 * A);
        var d2 = (-B - Math.Sqrt(D)) / (2 * A);
        return $"{Math.Sqrt(d1)}; {-Math.Sqrt(d1)}; {Math.Sqrt(d2)}; {-Math.Sqrt(d2)}";
    }

    public override string ToString() => Solve();
}
