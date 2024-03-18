using HR_Management.Application.DTOs.Leavetype;
using HR_Management.Application.Features.LeaveTypes.Requests;
using HR_Management.Application.Features.LeaveTypes.Requests.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR_Management.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LeaveTypeController : ControllerBase
{
    private IMediator _mediator;

    public LeaveTypeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<LeaveTypeController>
    [HttpGet]
    [Authorize]
    public async Task<ActionResult<List<LeaveTypeDto>>> Get()
    {
        return await _mediator.Send(new GetLeaveTypeListRequest());
    }

    // GET api/<LeaveTypeController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<LeaveTypeDto>> Get(int id)
    {
        return await _mediator.Send(new GetLeaveTypeDetailRequest { Id = id });
    }

    // POST api/<LeaveTypeController>
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateLeaveTypeDto leaveType)
    {
        var command = new CreateLeaveTypeRequestCommand { LeaveTypeDto = leaveType };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    // PUT api/<LeaveTypeController>/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] LeaveTypeDto leaveTypeDto)
    {
        var command = new UpdateLeaveTypeCommand { LeaveTypeDto = leaveTypeDto };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    // DELETE api/<LeaveTypeController>/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var command = new DeleteLeaveTypeCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}
//50// create other controller 