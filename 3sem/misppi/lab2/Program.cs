namespace lab2;
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

        foreach (Animal animal in animals)
        {
            animal.Print();
        }


        var birds = SearchByCanFly(animals);
        foreach (Animal animal in birds)
        {
            animal.Print();
        }

        var mammals = SearchByCanMammal(animals);
        foreach (Animal animal in mammals)
        {
            animal.Print();
        }

        var actios = SearchByHoof(animals);
        foreach (Animal animal in actios)
        {
            animal.Print();
        }
    }
}