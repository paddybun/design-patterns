using GammaPatterns.Lib.Enums;
using GammaPatterns.Lib.Models;

namespace GammaPatterns.Lib.AbstractFactoryPattern.Factories;

public class LegendaryEquipmentFactory: IEquipmentFactory
{
    public Rarity Rarity { get; init; } = Rarity.Legendary;
    public Equipment CreateWeapon(string name, int basePrice)
    {
        return new Weapon
        {
            BasePrice = basePrice,
            Name = $"{name} of legends",
            Rarity = Rarity
        };
    }

    public Equipment CreateArmor(string name, int basePrice)
    {
        return new ChestArmor
        {
            BasePrice = basePrice,
            Name = $"{name} of legends",
            Rarity = Rarity
        };
    }
}