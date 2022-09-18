namespace lab1;
class Program
{
    public static void Main()
    {
        Item banana = new Item() { Name = "Банан", ShopName = "Абсолют", Cost = 100, Amount = 2 };
        Item banana2 = new Item() { Name = "Банан", ShopName = "Монетка", Cost = 105, Amount = 2 };
        Item apple = new Item() { Name = "Яблоко", ShopName = "Монетка", Cost = 200, Amount = 1 };
        Information info1 = new Information(new Item[] { banana });
        Information info2 = new Information(new Item[] { banana2, apple });
        info1.Print();
        info2.Print();
        var shops = info1 + info2;
        Console.WriteLine($"");
        shops.ToList().ForEach(shop => Console.WriteLine($"{shop.ShopName} - {shop.Sum}"));
    }
}