using Domain.Common.DTOs;

namespace Users.API.Endpoints.GetAllUsers;

public class Response
{
    public IEnumerable<UserDTO>? Users { get; set; }
}
