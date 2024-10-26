namespace StartUpFoodDelivery;

public class MiddleState: IState
{
    public void GetInfoOfOrder()
    {
        Console.WriteLine("Пока готовятся блюда. Скоро всё будет завершено!");
    }

    public void ChangeOrderState(OrderState orderState)
    {
        orderState.SetOrderState(new FinishState());
    }
}