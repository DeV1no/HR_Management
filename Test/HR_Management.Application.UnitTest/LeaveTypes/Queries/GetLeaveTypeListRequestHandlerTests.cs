using AutoMapper;
using HR_Management.Application.DTOs.Leavetype;
using HR_Management.Application.Features.LeaveTypes.Handlers.Queries;
using HR_Management.Application.Features.LeaveTypes.Requests;
using HR_Management.Application.Persistance.Contracts;
using HR_Management.Application.Profiles;
using HR_Management.Application.UnitTest.Mocks;
using Moq;
using Shouldly;

namespace HR_Management.Application.UnitTest.LeaveTypes.Queries;

public class GetLeaveTypeListRequestHandlerTests
{
    private readonly IMapper _mapper;
    private readonly Mock<ILeaveTypeRepository> _mockRepository;
    public GetLeaveTypeListRequestHandlerTests()
    {
        _mockRepository = MockLeaveRepository.GetLeaveTypeRepository();

        var mapperConfig = new MapperConfiguration(m =>
        {
            m.AddProfile<MappingProfile>();
        });

        _mapper = mapperConfig.CreateMapper();
    }

    [Fact]
    public async Task GetLeaveTypeListTest()
    {
        var handler = new GetLeaveTypeListRequestHandler(_mockRepository.Object, _mapper);
        var result = await handler.Handle(new GetLeaveTypeListRequest(), CancellationToken.None);
        result.ShouldBeOfType<List<LeaveTypeDto>>();
        result.Count.ShouldBe(2);
    }
}
