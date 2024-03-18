using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Application.DTOs.Leavetype;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Requests.Commands;

public class CreateLeaveRequestCommand : IRequest<int>
{
    public CreateLeaveRequestDto LeaveRequestDto { get; set; } = new CreateLeaveRequestDto();
}

