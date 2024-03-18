using HR_Management.Application.DTOs.Leavetype;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Requests.Commands;

public class CreateLeaveTypeRequestCommand : IRequest<int>
{
    public CreateLeaveTypeDto LeaveTypeDto { get; set; } = new CreateLeaveTypeDto();
}