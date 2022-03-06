using CAExample.Application.UseCases.Order.ApproveOrder;
using CAExample.Application.UseCases.Order.CreateOrder;
using CAExample.Domain.Order;
using Microsoft.AspNetCore.Mvc;

namespace CAExample.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult> CreateOrder(
        [FromBody] CreateOrderInput input,
        [FromServices] ICreateOrder createUseCase
    )
    {
        var output = await createUseCase.Handle(input);
        return Ok(output);
    }

    [HttpPost("{id:guid}/approve")]
    public async Task<ActionResult> ApproveOrder(
        [FromRoute] Guid id,
        [FromServices] IApproveOrder approveUsecase
    )
    {
        await approveUsecase.Handle(new ApproveOrderInput(id));
        return NoContent();
    }
}
