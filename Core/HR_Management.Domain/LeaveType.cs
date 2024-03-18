using HR_Management.Domain.Common;

namespace HR_Management.Domain;

public class LeaveType:BaseDomainEntity
{
    public string Name { get; set; } = string.Empty;
    public int DefaultDay { get; set; }
}