namespace StartUpFoodDelivery.StatesOfPlace;

public class Place
{
    private IOrderType State { get; set; }
    
    public Place(IOrderType orderType)
    {
        State = orderType;
    }

    public void SetOrderPlace(IOrderType orderType)
    {
        State = orderType;
    }
    
    public void GetInfoOfOrder()
    {
        State.GetInfoOfPlace();
    }
}