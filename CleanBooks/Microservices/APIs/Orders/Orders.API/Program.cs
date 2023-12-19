using FastEndpoints;
using Orders.DataAccess.Repositories;
using Orders.DataAccess.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddFastEndpoints();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseFastEndpoints();

app.Run();
