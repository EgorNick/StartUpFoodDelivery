    using StartUpFoodDelivery.StatesOfPlace;

    namespace StartUpFoodDelivery;
    //шаблонный метод, open-close использовать
    public class OrderingFood
    {
        private OrderState orderState { get; set; } = new OrderState(new DefaultState());

        private IOrderType type { get; set; } = new DefaultOrder();
        
        private CreatingOrder creatingOrder { get; set; } = new CreatingOrder();
        
        public void FinishChoice()
        {
            type.GetInfoOfPlace();
            Console.WriteLine("Вы выбрали, такие блюда как: ");
            foreach (var food in creatingOrder.GetListOfFood())
            {
                Console.WriteLine($"Блюдо: {food.GetName()}. Количество порций: {food.GetValue()}. Стоимость блюда: {food.GetCurrentPrice()}");
            }
            StartOrder();
        }

        public void StartOrder()
        {
            orderState.ChangeState(new StartOrder());
            orderState.GetInfoOfOrder();
        }
        
        public void MiddleOrder()
        {
            orderState.ChangeState(new MiddleState());
            orderState.GetInfoOfOrder();
        }

        public void FinishOrder()
        {
            orderState.ChangeState(new FinishState());
            orderState.GetInfoOfOrder();
        }

        public void GetInfoOfOrder()
        {
            Console.WriteLine("Место получения: \t ");
            type.GetInfoOfPlace();
            Console.WriteLine("Ваш заказ: ");
            foreach (var food in creatingOrder.GetListOfFood())
            {
                Console.WriteLine($"{food.GetName()}: {food.GetValue()} \n {food.GetCurrentPrice()}");
            }
            creatingOrder.GetDescriptionOrder();
            Console.WriteLine("Состояние вашего заказа: \n");
            orderState.GetInfoOfOrder();
        }

        public OrderState GetOrderState()
        {
            return orderState;
        }
    }