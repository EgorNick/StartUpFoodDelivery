using StartUpFoodDelivery.StatesOfPlace;

namespace StartUpFoodDelivery;

public class CreatingOrder
{
    private int price { get; set; }
    
    private readonly List<Food> listOfFood = new List<Food>();

    private int value { get; set; }
    
    public void AddFood(Food newFood)
    {
        Food? ourFood = listOfFood.FirstOrDefault(food => food.GetName() == newFood.GetName());
        if (ourFood == null)
        {
            listOfFood.Add(newFood); 
            Console.WriteLine($"Добавленно: {newFood.GetName()}");
        }
        else
        {
            ourFood.SetValue(ourFood.GetValue() + newFood.GetValue());
            ourFood.SetCurrentPrice(ourFood.GetCurrentPrice() + newFood.GetPrice() * newFood.GetValue());
        }
        price += newFood.GetPrice() * newFood.GetValue();
        value += newFood.GetValue();
    }

    public void DeleteFood(Food newFood)
    {
        Food? ourFood = listOfFood.FirstOrDefault(food => food.GetName() == newFood.GetName());
        if (ourFood == null)
        {
            Console.WriteLine("Не удалось удалить блюдо");
        }
        else if (ourFood.GetValue() > 1)
        {
            ourFood.SetValue(ourFood.GetValue() - 1);
            ourFood.SetCurrentPrice(ourFood.GetCurrentPrice() - GetPrice());
        }
        else
        {
            listOfFood.Remove(ourFood);
        }
    }

    public void GetDescriptionOrder()
    {
        Console.WriteLine($"Количество ваших блюд: {value} \n Итого: {price}");
    }

    public List<Food> GetListOfFood()
    {
        return listOfFood;
    }

    public int GiveValue()
    {
        return value;
    }

    public int GetPrice()
    {
        return price;
    }
}