namespace StartUpFoodDelivery.StatesOfPlace;

public class DeliveryOrder: IOrderType
{

    public void ChangePlace(Place orderPlace)
    {
        orderPlace.SetOrderPlace(new DefaultOrder());
    }

    public void GetInfoOfPlace()
    {
        Console.WriteLine("Доставка на дом \n");
    }
}