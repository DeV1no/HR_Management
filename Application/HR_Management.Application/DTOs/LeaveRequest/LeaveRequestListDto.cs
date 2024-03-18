using HR_Management.Application.DTOs.Common;
using HR_Management.Application.DTOs.Leavetype;

namespace HR_Management.Application.DTOs.LeaveRequest;

public class LeaveRequestListDto:BaseDto
{
    public LeaveTypeDto LeaveType { get; set; } = new LeaveTypeDto();
    public DateTime DateRequest { get; set; }
    public bool? Approved { get; set; }

}