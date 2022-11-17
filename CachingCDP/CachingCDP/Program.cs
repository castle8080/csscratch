using Microsoft.Extensions.DependencyInjection;
using CachingCDP;

public class Program
{
    public static async Task Main(String[] args)
    {
        IServiceCollection serviceCollection = new ServiceCollection();

        // Add the cache implementation to the container.
        serviceCollection.AddSingleton<ICache<object>, CacheMemory<object>>();

        // Register the repo under the concrete class.
        serviceCollection.AddSingleton<MyRepo, MyRepo>();

        // Register the cache based repo
        serviceCollection.AddSingleton<MyRepoCached>(sp => new MyRepoCached(sp.GetService<MyRepo>(), sp.GetService<ICache<object>>()));

        // Alias the cached repo as the default for the repo interface.
        serviceCollection.AddSingleton<IMyRepo>(sp => sp.GetService<MyRepoCached>());

        // Register jobs
        serviceCollection.AddTransient<MyJob1>();

        // Job 2 is weird. It wants to control if it uses cache or not.
        serviceCollection.AddTransient<MyJob2>(sp => new MyJob2(sp.GetService<MyRepo>(), sp.GetService<MyRepoCached>()));


        // Build the service provider.
        IServiceProvider sp = serviceCollection.BuildServiceProvider();

        // Run jobs
        await sp.GetService<MyJob1>().Run();
        await sp.GetService<MyJob2>().Run();
    }
}