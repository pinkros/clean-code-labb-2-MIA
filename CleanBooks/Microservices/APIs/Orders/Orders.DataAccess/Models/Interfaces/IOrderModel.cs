using Domain.Common.Interfaces.DataAccess;

namespace Books.DataAccess.Repositories.Orders.DataAccess.Models.Interfaces;

public interface IOrderModel : IEntity<Guid>
{
    string UserId { get; set; }
    ICollection<string> Products { get; set; }
}