namespace Application.Contracts;

public interface IAsyncRepository<T> where T : class
{
    Task<T?> GetbyIdAsync(long id);
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<IReadOnlyList<T>> GetPagedAsync(int page, int size);
}
