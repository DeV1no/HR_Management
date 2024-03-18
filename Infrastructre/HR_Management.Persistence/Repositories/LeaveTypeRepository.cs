using HR_Management.Application.Persistance.Contracts;
using HR_Management.Domain;

namespace HR_Management.Persistence.Repositories;

public class LeaveTypeRepository:GenericRepository<LeaveType>,ILeaveTypeRepository
{
    private readonly LeaveManagementDbContext _context;
    public LeaveTypeRepository(LeaveManagementDbContext context) : base(context)
    {
        _context = context;
    }
}