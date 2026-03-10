namespace MyCApp;

class Program
{
    static void Main(string[] args)
    {
        var order = new Order
        {
            Id = 1,
            Product = "Laptop",
            Quantity = 2,
            Price = 1000
        };

        var service = new OrderService();

        if (service.IsValidOrder(order))
        {
            var total = service.CalculateTotal(order);
            Console.WriteLine($"Order Total: {total}");
        }
        else
        {
            Console.WriteLine("Invalid order");
        }
    }
}