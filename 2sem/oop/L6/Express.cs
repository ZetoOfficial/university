namespace L6
{
    public class Express : Vehicle
    {
        private int vagons;
        public int Vagons { get => vagons; set => vagons = value; }

        public Express() : base() { }
        public Express(string name) : base(name) { }
        public Express(string name, string color) : base(name, color) { }
        public Express(string name, string color, string zodiacSign) : base(name, color, zodiacSign) { }
        public Express(string name, string color, string zodiacSign, int speed) : base(name, color, zodiacSign, speed) { }

        public bool checkVagons(int vagonNum)
        {
            return vagonNum == this.vagons;
        }

        public override void Move(string? endpoint) => Console.WriteLine($"Экспресс ({Color} {Name}, {ZodiacSign}) отправляется в {endpoint}. У нас есть Wi-Fi.");
        public override void SpeedUp(int newSpeed)
        {
            Speed = newSpeed;
            Console.WriteLine($"Экспресс \"{Name}\" увеличил свою скорость до {newSpeed}...");
        }
        public override void Teleport(string? location) => Console.WriteLine($"&^%#!@#!@#!@#!JH@G#!@JKGH#!@J#HG!@#K Done. Добро пожаловать в {location}");
        public override void BeepBeep(int duration) { for (int i = 0; i < duration; i++) { Console.WriteLine($"BEEP ..."); } }
        public override void DopInfo()
        {
            Console.WriteLine("Dop info for Express");
        }
    }
}