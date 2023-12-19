using Domain.Common.DTOs;

namespace Books.API.Endpoints.AddNew;

public class Request
{
    public BookDTO NewBook { get; set; } 
}