using HR_Management.Application.DTOs.Common;

namespace HR_Management.Application.DTOs.Leavetype;

public class CreateLeaveTypeDto : BaseDto
{
    public string Name { get; set; } = string.Empty;
    public int DefaultDay { get; set; }
}