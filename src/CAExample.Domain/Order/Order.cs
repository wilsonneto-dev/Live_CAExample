namespace CAExample.Domain.Order;
public class Order
{
    public Guid Id { get; private set; }
    public int CustomerCode { get; private set; }
    public int ProductCode { get; private set; }
    public OrderStatus Status { get; private set; }

    public Order(int customerCode, int productCode)
    {
        Id = Guid.NewGuid();
        CustomerCode = customerCode;
        ProductCode = productCode;
        Status = OrderStatus.Initiated;
    }
    
    public void Approve()
    {
        if (Status == OrderStatus.Approved 
            || Status == OrderStatus.Cancelled)
            throw new StatusChangeNotAllowedException("Operation not allowed.");
        
        Status = OrderStatus.Approved;
    }
}
