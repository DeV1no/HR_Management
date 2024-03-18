using HR_Management.Application.DTOs.Common;

namespace HR_Management.Application.DTOs.LeaveRequest;

public class LeaveRequestDto : BaseDto
{
    public string Name { get; set; } = string.Empty;
    public int DefaultDay { get; set; }
    public int LeaveTypeId { get; set; }
    public DateTime DateRequest { get; set; }
    public string RequestComments { get; set; } = string.Empty;
    public DateTime? DateActioned { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
}