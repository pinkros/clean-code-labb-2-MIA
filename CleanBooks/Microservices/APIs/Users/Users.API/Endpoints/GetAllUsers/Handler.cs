using Domain.Common.DTOs;
using FastEndpoints;
using Users.DataAccess.Repositories.Interfaces;

namespace Users.API.Endpoints.GetAllUsers;

public class Handler(IUserRepository userRepository) : Endpoint<Request, Response>
{
    public override void Configure()
    {
        Get("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request request, CancellationToken cancellationToken)
    {
        var all = await userRepository.GetAllAsync();
        var dtos = all.Select(model => new UserDTO(model.Email));

        await SendAsync(
            new Response()
            {
                Users = dtos
            },
            cancellation: cancellationToken);
    }
}
