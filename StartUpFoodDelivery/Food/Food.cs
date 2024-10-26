namespace StartUpFoodDelivery;

public abstract class Food
{
    private string name;
    private int price;
    private int value;

    public abstract void SetCurrentPrice(int price);
    public abstract int GetCurrentPrice();
    
    public abstract int GetPrice();
    
    public abstract void SetName(string name);
    
    public abstract string GetName();
    
    public abstract void SetValue(int value);
    
    public abstract int GetValue();
}