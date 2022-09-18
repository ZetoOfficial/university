namespace lab1;


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
        _items[index].Print();
    }
    public void PrintByName(string name)
    {
        var currentItem = Array.Find(_items, el => el.Name == name);
        if (currentItem is null)
        {
            throw new ArgumentException("Товара с заданным именем не существует!");
        }
        currentItem.Print();
    }
    public Item[] SortItemsBy(string sortBy)
    {
        switch (sortBy)
        {
            case "name": return _items.OrderBy(el => el.Name).ToArray();
            case "shop name": return _items.OrderBy(el => el.ShopName).ToArray();
            case "cost": return _items.OrderBy(el => el.Cost).ToArray();
        }
        throw new ArgumentException("Нельзя отсортировать по заданному полю");
    }
    public static ShopSum[] operator +(Information h1, Information h2)
    {
        Item[] allItems = h1.GetItems.Union(h2.GetItems).ToArray();
        ShopSum[] shops = { };
        foreach (var item in allItems)
        {
            var currentItem = shops.FirstOrDefault(x => x.ShopName.Equals(item.ShopName), null);
            if (currentItem is null)
                shops = shops.Append(new ShopSum() { ShopName = item.ShopName, Sum = item.Cost }).ToArray();
            else
                currentItem.Sum += item.Cost;
        }
        return shops;
    }
}