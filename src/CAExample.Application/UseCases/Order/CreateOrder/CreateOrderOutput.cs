namespace CAExample.Application.UseCases.Order.CreateOrder;
public class CreateOrderOutput
{
    public Guid OrderId { get; set; }
    public CreateOrderOutput(Guid orderId) => OrderId = orderId;
}
