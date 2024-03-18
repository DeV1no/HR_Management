using HR_Management.Application.DTOs.LeaveRequest;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Requests.Commands;

public class UpdateLeaveRequestCommand : IRequest<Unit>
{
    public int Id { get; set; }
    public UpdateLeaveRequestDto LeaveRequestDto { get; set; } = new UpdateLeaveRequestDto();
    public ChangeLeaveRequestApprovealDto ChangeLeaveRequestApprovealDto { get; set; } = new ChangeLeaveRequestApprovealDto();

}