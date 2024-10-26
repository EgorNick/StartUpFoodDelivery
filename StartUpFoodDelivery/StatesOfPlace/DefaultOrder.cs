namespace StartUpFoodDelivery.StatesOfPlace;

public class DefaultOrder: IOrderType
{

    public void ChangePlace(Place orderPlace)
    {
        orderPlace.SetOrderPlace(new DeliveryOrder());
    }

    public void GetInfoOfPlace()
    {
        Console.WriteLine("В ресторане \n ");
    }
}