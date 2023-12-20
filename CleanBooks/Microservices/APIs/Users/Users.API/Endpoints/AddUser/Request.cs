using Domain.Common.DTOs;

namespace Users.API.Endpoints.AddUser;

public class Request
{
    public UserDTO NewUser { get; set; }
}
