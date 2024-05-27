using Domain.Common;

namespace Domain.Entities;

public class User
{
    public long Id { get; set; }
    public required AuditableEntity AuditableEntity { get; set; }
    public required string Name { get; set; }
}
