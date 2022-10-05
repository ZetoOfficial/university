namespace lab2;
class Artiodactyl : Mammalia
{
    private int hoofCount = 4;
    public int HoofCount { get => hoofCount; set => hoofCount = value; }
    public Artiodactyl() => HoofCount = 4;

    public Artiodactyl(int hoofCount) => HoofCount = hoofCount;
    public Artiodactyl(int hoofCount, string name) : base(name) => HoofCount = hoofCount;
    public Artiodactyl(int hoofCount, string name, double speed) : base(name, speed) => HoofCount = hoofCount;
    public Artiodactyl(int hoofCount, string name, double speed, int sleepTime = 480, bool isSleep = false) : base(name, speed, sleepTime, isSleep) => HoofCount = hoofCount;

    public Artiodactyl(string name) : base(name) { }
    public Artiodactyl(string name, double speed) : base(name, speed) { }
    public Artiodactyl(string name, double speed, int sleepTime) : base(name, speed, sleepTime) { }
    public Artiodactyl(string name, double speed, int sleepTime, bool isSleep) : base(name, speed, sleepTime, isSleep) { }

    public override void Move()
    {
        base.Move();
        Console.WriteLine("скок-скок-скок");
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Hoof Count {HoofCount}");
    }
}