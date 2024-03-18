using HR_Management.Application.DTOs.Leavetype;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Requests;

public class GetLeaveTypeDetailRequest:IRequest<LeaveTypeDto>
{
    public int Id { get; set; }
}