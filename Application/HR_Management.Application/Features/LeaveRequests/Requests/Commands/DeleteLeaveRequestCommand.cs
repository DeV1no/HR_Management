using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Requests.Commands;

public class DeleteLeaveRequestCommand : IRequest<Unit>
{
    public int Id { get; set; }
}