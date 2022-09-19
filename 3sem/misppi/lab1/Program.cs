namespace lab1;
class Program
{
    public static void Main()
    {
        // Товары
        Item banana = new Item() { Name = "Банан", ShopName = "Абсолют", Cost = 1000, Amount = 2 };
        Item banana2 = new Item() { Name = "Банан", ShopName = "Монетка", Cost = 105, Amount = 2 };
        Item apple = new Item() { Name = "Яблоко", ShopName = "Монетка", Cost = 200, Amount = 1 };
        Item apple2 = new Item() { Name = "Яблоко", ShopName = "Монетка", Cost = 300, Amount = 1 };
        // Справки
        Information info1 = new Information(new Item[] { banana });
        Information info2 = new Information(new Item[] { banana, banana2, apple });
        // вывод информации о товаре по номеру с помощью индекса;
        try
        {
            info1.PrintByIndex(0);
            info1.PrintByIndex(100);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        // вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение;
        try
        {
            info1.PrintByName("Яблоко");
            info1.PrintByName("Ананас");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        // сортировку товаров по названию магазина, по наименованию и по цене;
        Console.WriteLine("Sort example Name");
        info2.SortItemsByName(SortType.Cost).ToList().ForEach(shop => shop.Print());
        Console.WriteLine("Sort example ShopName");
        info2.SortItemsByShopName(SortType.Amount).ToList().ForEach(shop => shop.Print());
        Console.WriteLine("Sort example Cost");
        info2.SortItemsByCost(SortType.ShopName).ToList().ForEach(shop => shop.Print());
        // перегруженную операцию сложения товаров, выполняющую сложение их общей стоимости с группировкой по магазинам.
        var shops = info1 + info2;
        shops.ToList().ForEach(shop => Console.WriteLine($"{shop.ShopName} - {shop.Sum}"));
    }
}