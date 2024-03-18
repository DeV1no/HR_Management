using HR_Management.Application.DTOs.Leavetype;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Requests;

public class GetLeaveTypeListRequest:IRequest<List<LeaveTypeDto>>
{
    
}