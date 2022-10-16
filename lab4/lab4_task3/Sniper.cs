namespace lab4_task3
{
    public struct ResultPoints
    {
        public Point Center;
        public List<Point> Trying;
    }

    public class Sniper
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public int Padding { get; set; }
        public int ShotsCount { get; set; }
        public int ShotsPoints { get; set; }
        public List<Point> AllTries { get; set; }
        private Point Center { get; set; }

        public Sniper (int width, int length, int padding = 0) { 
            Width = width; 
            Length = length;
            Padding = padding;
            RestartGame();
        }

        public void RestartGame()
        {
            ShotsCount = 0;
            ShotsPoints = 0;
            Center = GenCenter();
            AllTries = new List<Point>();
        }
        
        public Point GenCenter()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            return new Point(random.Next(Padding, Width - Padding), random.Next(Padding, Length - Padding));
        }

        public ResultPoints GetResults()
        {
            ResultPoints result = new ResultPoints();
            if (ShotsPoints < 10) return result;
            result.Center = Center;
            result.Trying = AllTries;
            return result;
        }
        
        public double GetLength(Point one, Point two)
        {
            return Math.Sqrt(Math.Pow(one.X - two.X, 2) + Math.Pow(one.Y - two.Y, 2));
        }

        public void Shot(Point trajectory)
        {
            double length = GetLength(Center, trajectory);
            length /= 30;
            ShotsCount++;
            AllTries.Add(trajectory);

            if ((Int32)length == 0)
            {
                ShotsPoints += 10;
            }
            else if (length <= 10)
            {
                ShotsPoints += 10 - (Int32)length;
            }
            else if (length > 10)
            {
                ShotsPoints = 0;
            }
        }
    }
}
