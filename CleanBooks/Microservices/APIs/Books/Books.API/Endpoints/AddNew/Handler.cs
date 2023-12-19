using Books.DataAccess.Models;
using Books.DataAccess.Repositories.Interfaces;
using FastEndpoints;

namespace Books.API.Endpoints.AddNew;

public class Handler(IBookRepository bookRepository) : Endpoint<Request, Response>
{
    public override void Configure()
    {
        Post("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request request, CancellationToken cancellationToken)
    {
        var book = new BookModel()
        {
            Name = request.NewBook.Name,
            Author = request.NewBook.Author
        };

        await bookRepository.AddAsync(book);
       
        await SendAsync(new Response(), cancellation: cancellationToken);
    }
}