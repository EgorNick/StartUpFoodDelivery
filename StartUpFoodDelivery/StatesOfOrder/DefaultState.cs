namespace StartUpFoodDelivery;

public class DefaultState: IState
{
    public void GetInfoOfOrder()
    {
    Console.WriteLine("Пока нет активных заказов еды");
    }

    public void ChangeStateOfOrder(OrderState orderState)
    {
        orderState.SetOrderState(new StartOrder());
    }
}