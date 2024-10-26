namespace StartUpFoodDelivery;

public class Drink: Food
{
    private string drink;
    private int currentPrice;
    private int price;
    private int value;
    
    public Drink(int Price, int Value, string Drink)
    {
        currentPrice = Price * Value;
        price = Price;
        drink = Drink;
        value = Value;
    }

    public override void SetCurrentPrice(int newPrice)
    {
        currentPrice = newPrice;
    }

    public override int GetCurrentPrice()
    {
        return currentPrice;
    }

    public override int GetPrice()
    {
        return price;
    }

    public override void SetName(string Drink)
    {
        drink = Drink;
    }

    public override string GetName()
    {
        return drink;
    }

    public override void SetValue(int Value)
    {
        value = Value;
    }

    public override int GetValue()
    {
        return value;
    }
}