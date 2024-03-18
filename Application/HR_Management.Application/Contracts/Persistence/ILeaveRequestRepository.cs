using HR_Management.Domain;

namespace HR_Management.Application.Persistance.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
    Task<List<LeaveRequest>> GetLeaveRequestWithDetails();
    Task ChangeApprovalStatus(LeaveRequest? leaveRequest, bool? approved);
}
