using Books.DataAccess.Repositories.Orders.DataAccess.Models.Interfaces;
using Domain.Common.Interfaces.DataAccess;

namespace Books.DataAccess.Repositories.Orders.DataAccess.Models;

public class OrderModel : IOrderModel
{
    public Guid Id { get; }
    public string UserId { get; set; }
    public ICollection<string> Products { get; set; }
}