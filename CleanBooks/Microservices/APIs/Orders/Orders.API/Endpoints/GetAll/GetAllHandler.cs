using Domain.Common.DTOs;
using FastEndpoints;
using Orders.DataAccess.Repositories.Interfaces;

namespace Orders.API.Endpoints.GetAll;

public class GetAllHandler(IOrderRepository orderRepository) : Endpoint<GetAllRequest, GetAllResponse>
{
    public override void Configure()
    {
        Get("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetAllRequest req, CancellationToken ct)
    {
        var allOrders = await orderRepository.GetAllAsync();
        var orderDtos = allOrders.Select(
            o =>
                new OrderDTO(
                    o.UserId,
                    o.Books
                ));
        await SendAsync(new GetAllResponse()
        {
            Orders = orderDtos
        });

    }


}