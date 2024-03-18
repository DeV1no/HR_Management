using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Application.Features.LeaveRequests.Requests;
using HR_Management.Application.Features.LeaveRequests.Requests.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LeaveRequestController : ControllerBase
{
    private readonly IMediator _mediator;

    public LeaveRequestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<LeaveRequestDto>>> GetAll()
    {
        var leaveRequestList = await _mediator.Send(new GetLeaveRequestListRequest());
        return Ok(leaveRequestList);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<LeaveRequestDto>> Get(int id)
    {
        var leaveRequest = await _mediator.Send(new GetLeaveRequestDetailRequest { Id = id });
        return Ok(leaveRequest);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateLeaveRequestDto leaveRequest)
    {
        var command = new CreateLeaveRequestCommand { LeaveRequestDto = leaveRequest };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveRequestDto leaveRequest)
    {
        var command = new UpdateLeaveRequestCommand { LeaveRequestDto = leaveRequest, Id = id };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        var command = new DeleteLeaveRequestCommand { Id = id };
        var response = await _mediator.Send(command);
        return Ok(response);
    }
}