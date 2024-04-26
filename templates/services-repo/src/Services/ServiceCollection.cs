using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using NamespacePlaceholder.ProjectName.Hosted;

namespace NamespacePlaceholder.ProjectName;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectName(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Bindet Root-Konfigurationswerte an ProjectNameSettings
        services.Configure<ProjectNameSettings>(configuration.GetSection(ProjectNameSettings.SectionName));
        
        // Dienste hinzufügen
        services.AddHostedService<SampleHostedService>();
        
        return services;
    }
}
