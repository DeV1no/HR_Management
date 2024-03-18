using HR_Management.Domain.Common;

namespace HR_Management.Domain;

public class LeaveRequest:BaseDomainEntity
{
    public string Name { get; set; } = string.Empty;
    public int DefaultDay { get; set; }
    public LeaveType LeaveType { get; set; } = new LeaveType();
    public int LeaveTypeId { get; set; }
    public DateTime DateRequest { get; set; }
    public string RequestComments { get; set; }= string.Empty;
    public DateTime? DateActioned { get; set; }
    public bool?  Approved { get; set; }
    public bool  Cancelled { get; set; }

}