using MyCApp;
using Xunit;

namespace MyCApp.Tests;

public class OrderServiceTests
{
    [Fact]
    public void CalculateTotal_ShouldReturnCorrectTotal()
    {
        var order = new Order
        {
            Quantity = 3,
            Price = 10
        };

        var service = new OrderService();

        var total = service.CalculateTotal(order);

        Assert.Equal(30, total);
    }

    [Fact]
    public void IsValidOrder_ShouldReturnTrue_WhenOrderValid()
    {
        var order = new Order
        {
            Quantity = 1,
            Price = 20
        };

        var service = new OrderService();

        var result = service.IsValidOrder(order);

        Assert.True(result);
    }
}