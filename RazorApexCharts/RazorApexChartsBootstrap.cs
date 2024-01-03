using Microsoft.Extensions.DependencyInjection;
using RazorApexCharts.ContentSecurityPolicy;

namespace RazorApexCharts;

public static class RazorApexChartsBootstrap
{
    public static IServiceCollection AddRazorApexCharts(this IServiceCollection services)
    {
        services.AddTransient<IApexContentSecurityPolicy, ApexContentSecurityPolicy>();
        return services;
    } 
}