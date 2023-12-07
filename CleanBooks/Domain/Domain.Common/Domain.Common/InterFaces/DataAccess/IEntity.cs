namespace Domain.Common.InterFaces.DataAccess;

public interface IEntity<out T>
{
    T Id { get; }
}