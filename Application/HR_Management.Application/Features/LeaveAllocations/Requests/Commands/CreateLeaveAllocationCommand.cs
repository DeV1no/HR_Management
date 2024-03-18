using HR_Management.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HR_Management.Application.Features.LeaveAllocations.Requests.Commands;

public class CreateLeaveAllocationCommand : IRequest<int>
{
    public CreateLeaveAllocationDto LeaveAllocationDto { get; set; } = new CreateLeaveAllocationDto();
}