using Books.DataAccess.Repositories.Interfaces;
using Domain.Common.DTOs;
using FastEndpoints;

namespace Books.API.Endpoints.GetAll;

public class Handler(IBookRepository bookRepository) : Endpoint<Request, Response>
{
    public override void Configure()
    {
        Get("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request request, CancellationToken cancellationToken)
    {
        var books = await bookRepository.GetAllAsync();
        var dtos = books.Select(book => new BookDTO(
            book.Name,
            book.Author
            )
            );

        await SendAsync( new Response()
        {
            Books = dtos
        }, 
            cancellation: cancellationToken);
    }
}
