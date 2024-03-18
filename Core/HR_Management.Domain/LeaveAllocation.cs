using HR_Management.Domain.Common;

namespace HR_Management.Domain;

public class LeaveAllocation:BaseDomainEntity
{
    public string NumberOfDays { get; set; } = string.Empty;
    public LeaveType LeaveType { get; set; } = new LeaveType();
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}