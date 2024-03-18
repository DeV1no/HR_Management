using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Application.DTOs.Leavetype;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Requests.Commands;

public class UpdateLeaveTypeCommand : IRequest<Unit>
{
    public LeaveTypeDto LeaveTypeDto { get; set; } = new LeaveTypeDto();
}