namespace lab3;
abstract class Animal
{
    private string name = "animal name";
    private double speed = 1.0;
    private DateTime sleepAt;
    private int sleepTime = 1;
    private bool isSleep = false;

    public string Name
    {
        get => name; set => name = value;
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
        Name = "animal example information";
        Speed = 1.0;
        SleepTime = 480; // time in minutes
        IsSleep = false;
    }
    public Animal(string name)
    {
        Name = name;
        Speed = 1.0;
        SleepTime = 480;
        IsSleep = false;
    }
    public Animal(string name, double speed)
    {
        Name = name;
        Speed = speed;
        SleepTime = 480;
        IsSleep = false;
    }
    public Animal(string name, double speed, int sleepTime)
    {
        Name = name;
        Speed = speed;
        SleepTime = sleepTime;
        IsSleep = false;
    }
    public Animal(string name, double speed, int sleepTime, bool isSleep)
    {
        Name = name;
        Speed = speed;
        SleepTime = sleepTime;
        IsSleep = isSleep;
    }
    public abstract void Move();
    public abstract void Sleep();
    public void Print() => Console.WriteLine(ToString());
}