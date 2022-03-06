using CAExample.Domain.Order;
using DomainEntity = CAExample.Domain.Order;

namespace CAExample.Application.UseCases.Order.CreateOrder;
public class CreateOrder : ICreateOrder
{
    private readonly IOrderRepository _orderRepository;

    public CreateOrder(IOrderRepository orderRepository) 
        => _orderRepository = orderRepository;

    public async Task<CreateOrderOutput> Handle(CreateOrderInput input)
    {
        var order = new DomainEntity.Order(
            input.CustomerCode, 
            input.ProductCode
        );

        await _orderRepository.Insert(order);
        
        return new CreateOrderOutput(order.Id);
    }
}
