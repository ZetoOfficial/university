namespace lab3;
class Bird : Animal, Road, Sky
{
    private bool canFly = true;
    public bool CanFly { get => canFly; set => canFly = value; }
    public Bird() => CanFly = true;

    public Bird(bool canFly) => CanFly = canFly;
    public Bird(bool canFly, string name) : base(name) => CanFly = canFly;
    public Bird(bool canFly, string name, double speed) : base(name, speed) => CanFly = canFly;
    public Bird(bool canFly, string name, double speed, int sleepTime = 480, bool isSleep = false) : base(name, speed, sleepTime, isSleep) => CanFly = canFly;

    public Bird(string name) : base(name) { }
    public Bird(string name, double speed) : base(name, speed) { }
    public Bird(string name, double speed, int sleepTime) : base(name, speed, sleepTime) { }
    public Bird(string name, double speed, int sleepTime, bool isSleep) : base(name, speed, sleepTime, isSleep) { }

    void Road.Go() => Console.WriteLine("топ-топ, топ-топ)");
    void Sky.Go() => Console.WriteLine("ПОКОРЯЕМ НЕБЕСА, БЕСКОНЕЧНОСТЬ - НЕ ПРЕДЕЛ!");

    public override void Move() => Console.WriteLine("летаем)");
    public override void Sleep() => Console.WriteLine("Спим как птица)");
    public override string ToString() => $"|Bird|\nCan Fly {CanFly}";
}