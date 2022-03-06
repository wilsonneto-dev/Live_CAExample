using CAExample.Application.Exceptions;
using CAExample.Domain.Order;

namespace CAExample.Application.UseCases.Order.ApproveOrder;
public class ApproveOrder : IApproveOrder
{
    private readonly IOrderRepository _orderRepository;

    public ApproveOrder(IOrderRepository orderRepository) 
        => _orderRepository = orderRepository;

    public async Task Handle(ApproveOrderInput input)
    {
        var order = await _orderRepository.GetById(input.Id);
        if (order == null)
            throw new NotFoundException($"Order id '{input.Id}' not found");

        order.Approve();

        await _orderRepository.Update(order);
    }
}
