using AutoMapper;
using HR_Management.Application.Contracts.Infrastructure;
using HR_Management.Application.Features.LeaveRequests.Requests.Commands;
using HR_Management.Application.Persistance.Contracts;
using HR_Management.Domain;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Handlers.Commands;

public class CreateLeaveRequestHandler : IRequestHandler<CreateLeaveRequestCommand, int>
{
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;
    private readonly IEmailSender _emailSender;
    public CreateLeaveRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper,
        IEmailSender emailSender)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
        _emailSender = emailSender;
    }
    public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {

        var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
        var addedLeaveRequest = await _leaveRequestRepository.Add(leaveRequest);
        return addedLeaveRequest.Id;
    }
}
