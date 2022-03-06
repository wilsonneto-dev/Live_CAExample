using CAExample.Application.UseCases.Order.ApproveOrder;
using CAExample.Application.UseCases.Order.CreateOrder;
using CAExample.Domain.Order;
using CAExample.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ICreateOrder, CreateOrder>();
builder.Services.AddScoped<IApproveOrder, ApproveOrder>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
