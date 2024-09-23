namespace NorthwindApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddFastEndpoints();

        // Add services to the container.
        builder.Services.AddAuthorization();


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ProductCommandHandler).Assembly));


        //builder.Services.AddDbContextFactory<NorthwindContext>(options =>
        //{
        //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        //    options.EnableSensitiveDataLogging();   // This line is for development only
        //    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        //});

        // DbContextPool can be used instead of DbContextFactory for better performance
        builder.Services.AddDbContextPool<NorthwindContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            options.EnableSensitiveDataLogging();   // This line is for development only
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });

        // Register repositories
        builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddTransient<IProductRepository, ProductRepository>();
        builder.Services.AddTransient<IProductService, ProductService>();

        var app = builder.Build();
        app.UseFastEndpoints();

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.Run();
    }
}
