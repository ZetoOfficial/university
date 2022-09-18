// Титов Павел Сергеевич, Л0, q19
// Найти значение y = f(x, t)
namespace L0
{
    public class Titov_Pavel_00_19
    {
        public double F(int x, int t)
        {
            double firstTerm = (1 + Math.Pow(x, 2) - 2 * x * t) / Math.Sin(t); // если t = 0, то вылетает ошибка
            double secondTerm = 1;
            double thirdTerm = Math.Sqrt(1 + Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(x), 2) * t);
            return firstTerm + secondTerm + thirdTerm;
        }
        public void ShowInfo()
        {
            int x, t;
            Console.Write("Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите t: ");
            t = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(F(x, t));
            }
            catch
            {
                Console.WriteLine("Для данных x и t решений нет");
            }
        }
    }
}