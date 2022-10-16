namespace lab3;
delegate void Message();
class Program
{
    public static List<Animal> SearchByCanFly(List<Animal> animals)
    {
        return animals.FindAll(a => a as Bird != null && ((Bird)a).CanFly);
    }

    public static List<Animal> SearchByCanMammal(List<Animal> animals)
    {
        return animals.FindAll(a => (a as Mammalia != null && !((Mammalia)a).Sex));
    }

    public static List<Animal> SearchByHoof(List<Animal> animals)
    {
        return animals.FindAll(a => a as Artiodactyl != null && ((Artiodactyl)a).HoofCount > 0);
    }
    public static void Main()
    {
        List<Animal> animals = new List<Animal> {
            new Bird(name: "Пингвин)", canFly: false), new Mammalia(sex: true, name: "Blue Kit"), new Artiodactyl(hoofCount: 4, name: "Jiraf")
        };

        Bird pin = new Bird(name: "Пин)", canFly: false);

        Console.WriteLine("--> Delegate demo <--");
        Message mes;
        mes = pin.Move;
        mes += pin.Sleep;
        mes();

        Console.WriteLine("\n--> Print all animals <--");
        foreach (Animal animal in animals)
        {
            animal.Print();
        }

        Console.WriteLine("\n--> Print CanFly <--");
        var birds = SearchByCanFly(animals);
        foreach (Animal animal in birds)
        {
            animal.Print();
        }

        Console.WriteLine("\n--> Print CanMammal <--");
        var mammals = SearchByCanMammal(animals);
        foreach (Animal animal in mammals)
        {
            animal.Print();
        }

        Console.WriteLine("\n--> Print ByHoof <--");
        var actios = SearchByHoof(animals);
        foreach (Animal animal in actios)
        {
            animal.Print();
        }
    }
}