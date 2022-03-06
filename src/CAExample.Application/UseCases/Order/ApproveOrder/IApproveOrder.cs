namespace CAExample.Application.UseCases.Order.ApproveOrder;
public interface IApproveOrder
{
    public Task Handle(ApproveOrderInput input);
}
