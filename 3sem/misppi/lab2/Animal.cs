namespace lab2;
class Animal
{
    private string info = "animal example inf";
    private double speed = 1.0;
    private DateTime sleepAt;
    private int sleepTime = 1;
    private bool isSleep = false;

    public string Info
    {
        get => info; set => info = value;
    }

    public double Speed
    {
        get => speed; set => speed = value;
    }

    public int SleepTime
    {
        get => sleepTime; set => sleepTime = value;
    }

    public bool IsSleep
    {
        get => isSleep; set => isSleep = value;
    }

    public DateTime SleepAt
    {
        get => sleepAt; set => sleepAt = value;
    }

    public Animal()
    {
        Info = "animal example information";
        Speed = 1.0;
        SleepTime = 480; // time in minutes
        IsSleep = false;
    }
    public Animal(string textInfo, double speed, int sleepTime = 480, bool isSleep = false)
    {
        Info = textInfo;
        Speed = speed;
        SleepTime = sleepTime;
        IsSleep = isSleep;
    }
    public void Move() => Console.WriteLine("We move");
    public void Sleep() => IsSleep = !IsSleep;
    public void Print() => Console.WriteLine($"Info {Info}\nSpeed: {Speed}\nSleep Time: {SleepTime}\nSleep: {IsSleep}");
}