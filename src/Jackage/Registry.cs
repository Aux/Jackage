using Jackage.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Jackage;

public static class Registry
{
    public static void AddAllServices(this IServiceCollection services)
    {
        AddViewModels(services);
        AddJackageServices(services);
        AddJackboxServices(services);
    }

    public static void AddViewModels(this IServiceCollection services)
    {
        services.AddTransient<MainViewModel>();
    }

    public static void AddJackboxServices(this IServiceCollection services)
    {

    }

    public static void AddJackageServices(this IServiceCollection services)
    {

    }
}
