using HR_Management.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HR_Management.Application.Features.LeaveAllocations.Requests.Commands;

public class UpdateLeaveAllocationCommand : IRequest<Unit>
{
    public LeaveAllocationDto LeaveAllocationDto { get; set; } = new LeaveAllocationDto();
}