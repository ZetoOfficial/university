namespace lab1;
class Item
{
    public string Name { get; set; }
    public string ShopName { get; set; }
    public double Cost { get; set; }
    public double Amount { get; set; }
    public void Print()
    {
        Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine($"Info for: {Name}");
        Console.WriteLine($"ShopName: {ShopName}");
        Console.WriteLine($"Cost: {Cost}");
        Console.WriteLine($"Amount: {Amount}");
        Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    }
}