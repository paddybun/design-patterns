using GammaPatterns.Lib.AbstractFactoryPattern.Factories;
using GammaPatterns.Lib.Enums;
using GammaPatterns.Lib.Models;

namespace GammaPatterns.Lib.AbstractFactoryPattern;

public class AbstractFactoryUsageExample(IEnumerable<IEquipmentFactory> factories)
{
    private readonly Dictionary<Rarity, IEquipmentFactory> _factoryByRarity = ValidateAndBuildEquipmentFactories(factories);

    public List<Equipment> CreateLoot(int amount)
    {
        // Simulate loot creation, randomly choosing rarity and type
        var random = new Random();
        var loot = new List<Equipment>();
        var rarities = Enum.GetValues<Rarity>();
        for (int i = 0; i < amount; i++)
        {
            var rarity = rarities[random.Next(rarities.Length)];
            var factory = _factoryByRarity[rarity];
            loot.Add(random.Next(2) == 0
                ? factory.CreateWeapon($"Weapon_{i}", random.Next(10, 100))
                : factory.CreateArmor($"Armor_{i}", random.Next(10, 100)));
        }
        return loot;
    }

    // AI suggestion: Dictionary validation method to ensure all rarities are covered and no duplicates exist.
    // PBU suggestion: I would also include a separate Unit Test, to check the ioc container setup if there are no duplicates, or missing implementations.
    private static Dictionary<Rarity, IEquipmentFactory> ValidateAndBuildEquipmentFactories(
        IEnumerable<IEquipmentFactory> factories)
    {
        var factoryList = factories.ToList();
        var allRarities = Enum.GetValues<Rarity>();
        
        // Check for duplicates
        var duplicates = factoryList.GroupBy(f => f.Rarity)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();
        
        if (duplicates.Any())
            throw new InvalidOperationException($"Duplicate factories found for rarities: {string.Join(", ", duplicates)}");
        
        // Check for missing implementations
        var factoryDict = factoryList.ToDictionary(f => f.Rarity, f => f);
        var missingRarities = allRarities
            .Except(factoryDict.Keys)
            .ToList();
        
        if (missingRarities.Any())
            throw new InvalidOperationException($"Missing factory implementations for rarities: {string.Join(", ", missingRarities)}");
        
        return factoryDict;
    }
}