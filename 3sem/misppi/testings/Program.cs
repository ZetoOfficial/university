// Сравните время вычисления 35-го числа Фибоначчи
// при помощи
// формулы Бине,
// итерационной формулы,
// метода «разделяй и властвуй»,
// метода нисходящего динамического программирования,
// метода восходящего динамического программирования.

namespace testings;
internal class Program
{
    static void Bine(int n)
    {
        DateTime startTime = DateTime.Now;
        double phi = (1 + Math.Sqrt(5)) / 2;
        double psy = -1 / phi;
        double phiN = phi;
        double psyN = psy;
        for (int i = 1; i < n; i++)
        {
            phiN *= phi;
            psyN *= psy;
            Console.WriteLine($"t: {DateTime.Now.ToString("ss.fffffffK")} | ");
        }
        int answer = (int)Math.Round((phiN - psyN) / Math.Sqrt(5));
        DateTime endTime = DateTime.Now;
        Console.WriteLine($"Формула Бине. Ответ: {answer}");
        Console.WriteLine($"DateTime Start: {startTime.ToString("ss.fffffffK")}");
        Console.WriteLine($"DateTime Now:   {endTime.ToString("ss.fffffffK")}");
        Console.WriteLine($"Разница: {startTime.Subtract(endTime)}\n");
    }
    static void Main(string[] args)
    {
        // Bine(30);
        // Bine(35);
        Bine(42);
    }
}