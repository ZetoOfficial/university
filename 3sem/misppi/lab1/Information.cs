namespace lab1;

enum SortType
{
    Name,
    ShopName,
    Cost,
    Amount
}

class Information
{
    public class ShopSum
    {
        public string ShopName { get; set; }
        public double Sum { get; set; }
    }

    private Item[] _items;

    public Item[] GetItems { get => _items; }

    public Item this[int index]
    {
        get => _items[index];
        set => _items[index] = value;
    }

    public Information(Item[] items)
    {
        _items = items;
    }

    public void Print()
    {
        foreach (var item in _items)
        {
            item.Print();
        }
    }
    public void PrintByIndex(int index)
    {
        if (index >= _items.Length)
            throw new IndexOutOfRangeException(message: $"Максимальное кол-во элементов: {_items.Length}");
        _items[index].Print();
    }
    public void PrintByName(string name)
    {
        var currentItem = Array.Find(_items, el => el.Name == name);
        if (currentItem is null)
        {
            throw new ArgumentException($"Товара {name} не существует!");
        }
        currentItem.Print();
    }
    public Item[] ThenBySorting(IOrderedEnumerable<Item> temp_items, SortType thenBy)
    {
        switch (thenBy)
        {
            case SortType.Cost:
                return temp_items.ThenBy(el => el.Cost).ToArray();
            case SortType.ShopName:
                return temp_items.ThenBy(el => el.ShopName).ToArray();
            case SortType.Amount:
                return temp_items.ThenBy(el => el.Amount).ToArray();
            default:
                return temp_items.ToArray();
        }
    }
    public Item[] SortItemsByName(SortType thenBy = SortType.Name) => ThenBySorting(_items.OrderBy(el => el.Name), thenBy);
    public Item[] SortItemsByShopName(SortType thenBy = SortType.ShopName) => ThenBySorting(_items.OrderBy(el => el.ShopName), thenBy).ToArray();
    public Item[] SortItemsByCost(SortType thenBy = SortType.Cost) => ThenBySorting(_items.OrderBy(el => el.Cost), thenBy).ToArray();

    public static ShopSum[] operator +(Information h1, Information h2)
    {
        Item[] allItems = h1.GetItems.Union(h2.GetItems).ToArray();
        ShopSum[] shops = { };
        foreach (var item in allItems)
        {
            var currentItem = shops.FirstOrDefault(x => x.ShopName.Equals(item.ShopName));
            if (currentItem is null)
                shops = shops.Append(new ShopSum() { ShopName = item.ShopName, Sum = item.Cost }).ToArray();
            else
                currentItem.Sum += item.Cost;
        }
        return shops;
    }
}