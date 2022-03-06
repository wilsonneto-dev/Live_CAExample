namespace CAExample.Application.UseCases.Order.CreateOrder;
public interface ICreateOrder
{
    public Task<CreateOrderOutput> Handle(CreateOrderInput input);
}
