using Domain.Common.DTOs;

namespace Books.API.Endpoints.GetAll;

public class Response
{
    public IEnumerable<BookDTO>? Books { get; set; } 
}