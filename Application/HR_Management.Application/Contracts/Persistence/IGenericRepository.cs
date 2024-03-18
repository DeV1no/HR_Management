namespace HR_Management.Application.Persistance.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<T?> Get(int id);
    Task<IReadOnlyList<T>> GetAll();
    Task<T> Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<bool> Exist(int id);
}