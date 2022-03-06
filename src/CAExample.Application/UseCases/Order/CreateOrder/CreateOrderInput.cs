
namespace CAExample.Application.UseCases.Order.CreateOrder;
public class CreateOrderInput
{
    public int CustomerCode { get; set; }
    public int ProductCode { get; set; }

    public CreateOrderInput(int customerCode, int productCode)
    {
        CustomerCode = customerCode;
        ProductCode = productCode;
    }
}
