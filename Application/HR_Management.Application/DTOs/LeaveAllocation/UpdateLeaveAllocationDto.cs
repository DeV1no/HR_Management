using HR_Management.Application.DTOs.Common;

namespace HR_Management.Application.DTOs.LeaveAllocation;

public class UpdateLeaveAllocationDto : BaseDto
{
    public int NumbersOfDays { get; set; }
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }

}