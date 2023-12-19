using FastEndpoints;
using Users.DataAccess.Models;
using Users.DataAccess.Repositories.Interfaces;

namespace Users.API.Endpoints.AddUser;

public class Handler(IUserRepository userRepository) : Endpoint<Request, Response>
{
    public override void Configure()
    {
        Post("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request request, CancellationToken cancellationToken)
    {
        var user = new UserModel()
        {
            Email = request.NewUser.Email
        };

        await userRepository.AddAsync(user);

        await SendAsync(new Response(), cancellation: cancellationToken);
    }
}
