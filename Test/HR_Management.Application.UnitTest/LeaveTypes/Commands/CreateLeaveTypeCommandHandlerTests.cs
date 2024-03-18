using AutoMapper;
using HR_Management.Application.DTOs.Leavetype;
using HR_Management.Application.Features.LeaveTypes.Handlers.Commands;
using HR_Management.Application.Features.LeaveTypes.Requests.Commands;
using HR_Management.Application.Persistance.Contracts;
using HR_Management.Application.Profiles;
using HR_Management.Application.UnitTest.Mocks;
using Moq;
using Shouldly;

namespace HR_Management.Application.UnitTest.LeaveTypes.Commands;

public class CreateLeaveTypeCommandHandlerTests
{
    private readonly IMapper _mapper;
    private readonly Mock<ILeaveTypeRepository> _mockRepository;
    CreateLeaveTypeDto _leaveTypeDto;
    public CreateLeaveTypeCommandHandlerTests()
    {
        _mockRepository = MockLeaveRepository.GetLeaveTypeRepository();

        var mapperConfig = new MapperConfiguration(m =>
        {
            m.AddProfile<MappingProfile>();
        });

        _mapper = mapperConfig.CreateMapper();
        _leaveTypeDto = new CreateLeaveTypeDto
        {
            Id = 3,
            Name = "Test",
            DefaultDay = 15
        };
    }

    [Fact]
    public async Task CreateLeaveType()
    {
        var handler = new CreateLeaveTypeRequestHandler(_mockRepository.Object, _mapper);
        var result = await handler.Handle(new CreateLeaveTypeRequestCommand()
        {
            LeaveTypeDto = _leaveTypeDto

        }, CancellationToken.None);

        result.ShouldBeOfType<int>();
        
    }
}