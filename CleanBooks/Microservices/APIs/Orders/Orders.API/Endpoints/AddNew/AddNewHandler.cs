using Books.DataAccess.Repositories.Orders.DataAccess.Models;
using FastEndpoints;
using Orders.DataAccess.Repositories.Interfaces;

namespace Orders.API.Endpoints.AddNew;

public class AddNewHandler(IOrderRepository repository) : Endpoint<AddNewRequest, AddNewResponse>
{
    public override void Configure()
    {
        Post("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddNewRequest addNewRequest, CancellationToken cancellationToken)
    {
        
        await repository.AddAsync(
            new OrderEntity()
            {
                UserId = addNewRequest.NewOrder.UserId,
                Books = addNewRequest.NewOrder.BookIds
            }
        );

        await SendAsync(new AddNewResponse(), cancellation: cancellationToken);

    }
    
}