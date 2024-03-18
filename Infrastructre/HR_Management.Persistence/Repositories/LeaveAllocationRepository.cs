using HR_Management.Application.Persistance.Contracts;
using HR_Management.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Persistence.Repositories;

public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
{
    private readonly LeaveManagementDbContext _context;

    public LeaveAllocationRepository(LeaveManagementDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id)
        => await _context.LeaveAllocations
            .Include(q => q.LeaveType)
            .SingleAsync(x => x.Id == id);

    public async Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails()
       => await _context.LeaveAllocations
            .Include(q => q.LeaveType)
            .ToListAsync();

}