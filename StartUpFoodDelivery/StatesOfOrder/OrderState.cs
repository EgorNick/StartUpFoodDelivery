namespace StartUpFoodDelivery;

public class OrderState
{
    private IState State { get; set; }

    public OrderState(IState state)
    {
        State = state;
    }

    public void SetOrderState(IState state)
    {
        State = state;
    }
    
    public void GetInfoOfOrder()
    {
       State.GetInfoOfOrder();
    }

    public void ChangeState(IState state)
    {
        State = state;
    }
}