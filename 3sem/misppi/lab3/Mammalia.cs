namespace lab3;
class Mammalia : Animal
{
    private int mammaTime = 6480;
    public bool sex = true;
    public int MammaTime
    {
        get => mammaTime; set => mammaTime = value;
    }
    public bool Sex
    {
        get => sex; set => sex = value;
    }
    public Mammalia() => Sex = true;

    public Mammalia(bool sex) { Sex = sex; }
    public Mammalia(bool sex, string name) : base(name) { Sex = sex; }
    public Mammalia(bool sex, string name, double speed) : base(name, speed) { Sex = sex; }
    public Mammalia(bool sex, string name, double speed, int sleepTime = 480, bool isSleep = false) : base(name, speed, sleepTime, isSleep) { Sex = sex; }

    public Mammalia(string name) : base(name) { }
    public Mammalia(string name, double speed) : base(name, speed) { }
    public Mammalia(string name, double speed, int sleepTime) : base(name, speed, sleepTime) { }
    public Mammalia(string name, double speed, int sleepTime, bool isSleep) : base(name, speed, sleepTime, isSleep) { }

    public virtual void Mamma() => Console.WriteLine("рожаем)");
    public override void Sleep() => Console.WriteLine("Спим как млекопитающий)))");
    public override void Move() => Console.WriteLine("RUN");
    public override string ToString()
    {
        var sex = Sex ? "М" : "Ж";
        return $"|Mammalia|\nMamma Time: {MammaTime}\nПол: {sex}";
    }
}