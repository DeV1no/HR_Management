﻿using AutoMapper;
using HR_Management.Application.DTOs.Leavetype;
using HR_Management.Application.Features.LeaveTypes.Requests;
using HR_Management.Application.Persistance.Contracts;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Handlers.Queries;

public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;

    public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }
    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        var leaveTypeList = await _leaveTypeRepository.GetAll();
        return _mapper.Map<List<LeaveTypeDto>>(leaveTypeList);
    }
}
