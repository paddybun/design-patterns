using GammaPatterns.Lib.AbstractFactoryPattern.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace GammaPatterns.Lib.AbstractFactoryPattern;

public static class AbstractFactoryPatternModule
{
    public static IServiceCollection AddAbstractFactoryPattern(this IServiceCollection services)
    {
        services.AddTransient<AbstractFactoryUsageExample>();
        
        // Gamma recommendation to register the factories as singletons
        services.AddSingleton<IEquipmentFactory, CommonEquipmentFactory>();
        services.AddSingleton<IEquipmentFactory, UncommonEquipmentFactory>();
        services.AddSingleton<IEquipmentFactory, RareEquipmentFactory>();
        services.AddSingleton<IEquipmentFactory, EpicEquipmentFactory>();
        services.AddSingleton<IEquipmentFactory, LegendaryEquipmentFactory>();
        return services;
    }
}