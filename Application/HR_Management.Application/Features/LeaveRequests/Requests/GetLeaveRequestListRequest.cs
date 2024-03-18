using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Application.DTOs.Leavetype;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Requests;

public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>, IRequest<List<LeaveTypeDto>>
{
    
}