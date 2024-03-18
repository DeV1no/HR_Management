using HR_Management.Application.DTOs.Common;
using HR_Management.Application.DTOs.Leavetype;

namespace HR_Management.Application.DTOs.LeaveAllocation;

public class LeaveAllocationDto : BaseDto
{
    public string NumberOfDays { get; set; } = string.Empty;
    public LeaveTypeDto LeaveType { get; set; } = new LeaveTypeDto();
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}