using CAExample.Domain.Order;

namespace CAExample.Infra.Data.Repositories;
public class OrderRepository : IOrderRepository
{
    public readonly List<Order> _orders;

    public OrderRepository() => 
        _orders = new List<Order>();

    public Task<Order?> GetById(Guid id) 
        => Task.FromResult(_orders.Find(x => x.Id == id));
    
    public Task Insert(Order aggregate)
    {
        _orders.Add(aggregate);
        return Task.CompletedTask;
    }
    
    public Task Update(Order aggregate)
    {
        _orders.RemoveAll( x => x.Id == aggregate.Id);
        _orders.Add(aggregate);
        return Task.CompletedTask;
    }
}
