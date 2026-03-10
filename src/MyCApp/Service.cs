namespace MyCApp;

public class OrderService
{
    public decimal CalculateTotal(Order order)
    {
        return order.Quantity * order.Price;
    }

    public bool IsValidOrder(Order order)
    {
        return order.Quantity > 0 && order.Price > 0;
    }
}