namespace StartUpFoodDelivery;

public class StartOrder : IState
{
    public void GetInfoOfOrder()
    {
        Console.WriteLine("Ваш заказ начал готовиться. Примерно через пару минут, всё будет сделано!");
    }

    public void ChangeStateOfOrder(OrderState orderState)
    {
        orderState.SetOrderState(new StartOrder());
    }
}