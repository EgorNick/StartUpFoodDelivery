namespace StartUpFoodDelivery;

public class Dessert: Food
{
    private int price { get; set; }

    private int currentPrice { get; set; }

    private int value { get; set; }
    
    private string name { get; set; }

    public Dessert(int Price, int Value, string Name)
    {
        price = Price;
        currentPrice = Price * Value;
        name = Name;
        value = Value;
    }

    public override void SetCurrentPrice(int newPrice)
    {
        price = newPrice;
    }

    public override int GetCurrentPrice()
    {
        return currentPrice;
    }

    public override int GetPrice()
    {
        return price;
    }

    public override void SetName(string newName)
    {
        name = newName;
    }

    public override string GetName()
    {
        return name;
    }

    public override void SetValue(int newValue)
    {
        value = newValue;
    }

    public override int GetValue()
    {
        return value;
    }
}