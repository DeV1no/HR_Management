using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Requests.Commands;

public class DeleteLeaveTypeCommand : IRequest<Unit>
{
    public int Id { get; set; }
}