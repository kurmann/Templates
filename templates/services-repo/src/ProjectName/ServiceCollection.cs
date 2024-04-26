using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Kurmann.Videoschnitt.ProjectName.Services;

namespace Kurmann.Videoschnitt.ProjectName;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectName(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Bindet Root-Konfigurationswerte an ModuleSettings
        services.Configure<ModuleSettings>(configuration.GetSection(ModuleSettings.SectionName));
        
        // Dienste hinzufügen
        services.AddHostedService<SampleHostedService>();
        
        return services;
    }
}
