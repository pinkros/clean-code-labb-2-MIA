namespace Domain.Common.DTOs;

public record OrderDTO(string UserId, ICollection<Guid> BookIds);