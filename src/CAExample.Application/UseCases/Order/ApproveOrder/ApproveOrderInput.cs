namespace CAExample.Application.UseCases.Order.ApproveOrder;
public class ApproveOrderInput
{
    public Guid Id { get; set; }
    public ApproveOrderInput(Guid id) 
        => Id = id;
}
