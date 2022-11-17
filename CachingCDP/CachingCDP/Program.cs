using Microsoft.Extensions.DependencyInjection;
using Dazinator.Extensions.DependencyInjection;
using CachingCDP;

public static class Program
{
    /// <summary>
    /// This shows how you can use Dazinator to register and wire up named entries.
    /// </summary>
    private static void RegisterWithNamedServices(this IServiceCollection serviceCollection)
    {
        // Add the cache implementation to the container.
        serviceCollection.AddSingleton<ICache<object>, CacheMemory<object>>();

        serviceCollection.AddNamed<IMyRepo>(names => {
            names.AddSingleton<MyRepo>("Source");
            names.AddSingleton("Cached", sp => new MyRepoCached(
                sp.GetNamed<IMyRepo>("Source"),
                sp.GetService<ICache<object>>()
            ));
        });

        // Make the cached version the default
        serviceCollection.AddSingleton<IMyRepo>(sp => sp.GetNamed<IMyRepo>("Cached"));

        // Register jobs
        serviceCollection.AddTransient<MyJob1>();

        // Job 2 is weird. It wants to control if it uses cache or not.
        serviceCollection.AddTransient<MyJob2>(sp => new MyJob2(
            sp.GetNamed<IMyRepo>("Source"),
            sp.GetNamed<IMyRepo>("Cached")
        ));
    }

    /// <summary>
    /// The problem here can be solved also without named entries. Since there are different
    /// implementations.
    /// 
    /// Note: If I had a different case where I wanted more than 1 entry with the same concrete
    /// implementation class, I would also have a problem. An example would be having to cosmos db
    /// connection factories.
    /// 
    /// </summary>
    /// <param name="serviceCollection"></param>
    private static void RegisterStandardDI(this IServiceCollection serviceCollection)
    {
        // Add the cache implementation to the container.
        serviceCollection.AddSingleton<ICache<object>, CacheMemory<object>>();


        // Register the repo under the concrete class.
        serviceCollection.AddSingleton<MyRepo, MyRepo>();

        // Register the cache based repo
        serviceCollection.AddSingleton(sp => new MyRepoCached(
            sp.GetService<MyRepo>(),
            sp.GetService<ICache<object>>()
        ));

        // Alias the cached repo as the default for the repo interface.
        serviceCollection.AddSingleton<IMyRepo>(sp => sp.GetService<MyRepoCached>());

        // Register jobs
        serviceCollection.AddTransient<MyJob1>();

        // Job 2 is weird. It wants to control if it uses cache or not.
        serviceCollection.AddTransient<MyJob2>(sp => new MyJob2(
            sp.GetService<MyRepo>(),
            sp.GetService<MyRepoCached>()
        ));
    }

    public static async Task Main(String[] args)
    {
        IServiceCollection serviceCollection = new ServiceCollection();

        //serviceCollection.RegisterStandardDI();
        serviceCollection.RegisterWithNamedServices();

        // Build the service provider.
        IServiceProvider sp = serviceCollection.BuildServiceProvider();

        // Run jobs
        await sp.GetService<MyJob1>().Run();
        await sp.GetService<MyJob2>().Run();
    }
}