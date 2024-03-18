namespace HR_Management.Domain.Common;

public abstract class BaseDomainEntity
{
    public int Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = string.Empty;
    public DateTime LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; } = string.Empty;

}