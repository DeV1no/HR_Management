using HR_Management.Application.Persistance.Contracts;
using HR_Management.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Persistence.Repositories;

public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
{
    private readonly LeaveManagementDbContext _context;

    public LeaveRequestRepository(LeaveManagementDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        => await _context.LeaveRequests
            .Include(q => q.LeaveType)
            .SingleAsync(x => x.Id == id);

    public async Task<List<LeaveRequest>> GetLeaveRequestWithDetails()
    => await _context.LeaveRequests
        .Include(q => q.LeaveType)
        .ToListAsync();

    public async Task ChangeApprovalStatus(LeaveRequest? leaveRequest, bool? approved)
    {
        if (leaveRequest != null) leaveRequest.Approved = approved;
        _context.Entry(leaveRequest).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}