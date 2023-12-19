using Books.DataAccess.Repositories.Orders.DataAccess.Models;
using FastEndpoints;
using Orders.DataAccess.Repositories.Interfaces;

namespace Orders.API.Endpoints.AddNew;

public class Handler(IOrderRepository repository) : Endpoint<Request, Response>
{
    public override void Configure()
    {
        Post("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request request, CancellationToken cancellationToken)
    {
        if (request.Data is null)
        {
            await SendAsync(new Response("Fail", false, null), 400, CancellationToken.None);
            return;
        }

        await repository.AddAsync(
            new OrderEntity()
            {

            }
        );

        await SendAsync(new Response("DataAdded", true, request.Data), cancellation: cancellationToken);

    }

}