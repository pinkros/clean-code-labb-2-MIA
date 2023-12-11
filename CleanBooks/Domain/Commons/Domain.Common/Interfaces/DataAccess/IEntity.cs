namespace Domain.Common.Interfaces.DataAccess;

public interface IEntity<T>
{
    T Id { get; }
}