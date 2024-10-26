// See https://aka.ms/new-console-template for more information

using StartUpFoodDelivery;
using StartUpFoodDelivery.StatesOfPlace;

public class Program
{
    public static void Main()
    {
        var man = new CreatingOrder();
        Food meal1 = new Meal(15, 1, "Жаркое");
        Food meal2 = new Drink(18, 1, "Кофе");
        Food meal3 = new Dessert(15, 4, "Мороженное");
        man.AddFood(meal1);
        man.AddFood(meal1);
        var order = new OrderingFood();
        order.MiddleOrder();
        order.FinishOrder();
        order.FinishChoice();
        order.GetInfoOfOrder();
    }
}