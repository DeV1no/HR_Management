using HR_Management.Application.DTOs.Common;

namespace HR_Management.Application.DTOs.LeaveRequest;

public class UpdateLeaveRequestDto : BaseDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int LeaveTypeId { get; set; }
    public string RequestComments { get; set; } = string.Empty;
    public bool Cancelled { get; set; }
}