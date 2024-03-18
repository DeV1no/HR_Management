using HR_Management.Application.Persistance.Contracts;
using HR_Management.Domain;
using Moq;

namespace HR_Management.Application.UnitTest.Mocks;

public static class MockLeaveRepository
{
    public static Mock<ILeaveTypeRepository> GetLeaveTypeRepository()
    {
        var leaveTypes = new List<LeaveType>()
        {
            new()
            {
                Id = 10,
                DefaultDay = 10,
                Name="Test Vacation"
            },
            new()
            {
                Id = 2,
                DefaultDay = 15,
                Name="Test Sick"
            }
        };

        var mockRepo = new Mock<ILeaveTypeRepository>();
        mockRepo.Setup(r => r.GetAll()).ReturnsAsync(leaveTypes);
        mockRepo.Setup(r => r.Add(It.IsAny<LeaveType>()))
            .ReturnsAsync(
                (LeaveType leaveType) =>
                {
                    leaveTypes.Add(leaveType);
                    return leaveType;
                });
        return mockRepo;
    }
}