
namespace NorthwindApi.Data;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly IDbContextFactory<NorthwindContext> _contextFactory;

    public Repository(IDbContextFactory<NorthwindContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.Set<T>().FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.Set<T>().ToListAsync();
    }

    public async Task<int> AddAsync(T entity)
    {
        using var dbContext = await _contextFactory.CreateDbContextAsync();

        var entityEntry = await dbContext.Set<T>().AddAsync(entity);
        await dbContext.SaveChangesAsync();

        return (int) entityEntry.Property("Id").CurrentValue;
    }


    public async Task UpdateAsync(T entity)
    {
        using var context = _contextFactory.CreateDbContext();
        context.Set<T>().Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        using var context = _contextFactory.CreateDbContext();
        var entity = await context.Set<T>().FindAsync(id);
        if (entity != null)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}
