namespace lab3;
class Artiodactyl : Mammalia, Road
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

    void Road.Go() => Console.WriteLine("топ-топ копытами делаем");
    public override void Mamma() => Console.WriteLine("Рожаем как парнокопытное.");
    public override void Move() => Console.WriteLine("Скок-скок-скок");
    public override void Sleep() => Console.WriteLine("Спим как млекопитающий)))");
    public override string ToString() => $"|Artiodactyl|\nHoof Count: {HoofCount}";
}