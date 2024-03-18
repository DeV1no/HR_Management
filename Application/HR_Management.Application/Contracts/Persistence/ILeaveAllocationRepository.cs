using HR_Management.Domain;

namespace HR_Management.Application.Persistance.Contracts;

public interface ILeaveAllocationRepository:IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
    Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();
}