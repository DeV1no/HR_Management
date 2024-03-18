using HR_Management.Application.DTOs.LeaveRequest;
using MediatR;
using HR_Management.Application.DTOs.LeaveAllocation;

namespace HR_Management.Application.Features.LeaveAllocations.Requests;

public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
{

}