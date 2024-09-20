
namespace NorthwindApi.Data;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly NorthwindContext _context;

    public Repository(NorthwindContext context)
    {
        _context = context;
    }

    public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

    public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

    public async Task<int> AddAsync(T entity) 
    {
        var entityEntry = await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();

        return (int) entityEntry.Property("Id").CurrentValue;
    }


    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
