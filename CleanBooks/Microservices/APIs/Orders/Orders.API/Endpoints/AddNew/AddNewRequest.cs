using Domain.Common.DTOs;

namespace Orders.API.Endpoints.AddNew;

public class AddNewRequest
{
    public OrderDTO? NewOrder { get; set; }
}