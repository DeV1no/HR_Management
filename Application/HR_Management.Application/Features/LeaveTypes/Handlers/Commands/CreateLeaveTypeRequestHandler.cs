using AutoMapper;
using HR_Management.Application.Features.LeaveTypes.Requests.Commands;
using HR_Management.Application.Persistance.Contracts;
using HR_Management.Domain;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Handlers.Commands;

public class CreateLeaveTypeRequestHandler : IRequestHandler<CreateLeaveTypeRequestCommand, int>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public CreateLeaveTypeRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateLeaveTypeRequestCommand requestCommand, CancellationToken cancellationToken)
    {
        var leaveType = _mapper.Map<LeaveType>(requestCommand.LeaveTypeDto);
        var leaveTypeAdded = await _leaveTypeRepository.Add(leaveType);
        return leaveTypeAdded.Id;
    }
}