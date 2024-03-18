using HR_Management.Application.DTOs.LeaveAllocation;
using HR_Management.Application.Features.LeaveAllocations.Requests;
using HR_Management.Application.Features.LeaveAllocations.Requests.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LeaveAllocationsController : ControllerBase
{

    private readonly IMediator _mediator;

    public LeaveAllocationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<LeaveAllocationDto>>> GetAll()
    {
        var allocationList = await _mediator.Send(new GetLeaveAllocationListRequest());
        return Ok(allocationList);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<LeaveAllocationDto>> Get(int id)
    {
        var allocation = await _mediator.Send(new GetLeaveAllocationDetailRequest { Id = id });
        return Ok(allocation);
    }


    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateLeaveAllocationDto allocation)
    {
        var command = new CreateLeaveAllocationCommand { LeaveAllocationDto = allocation };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult> Put([FromBody] LeaveAllocationDto allocation)
    {
        var command = new UpdateLeaveAllocationCommand { LeaveAllocationDto = allocation };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult> Delete([FromBody] int id)
    {
        var command = new DeleteLeaveAllocationCommand { Id = id };
        var response = await _mediator.Send(command);
        return Ok(response);
    }
}