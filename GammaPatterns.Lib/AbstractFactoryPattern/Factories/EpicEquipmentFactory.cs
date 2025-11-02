using GammaPatterns.Lib.Shared.Enums;
using GammaPatterns.Lib.Shared.Models;

namespace GammaPatterns.Lib.AbstractFactoryPattern.Factories;

public class EpicEquipmentFactory: IEquipmentFactory
{
    public Rarity Rarity { get; init; } = Rarity.Epic;
    public Equipment CreateWeapon(string name, int basePrice)
    {
        return new Weapon
        {
            BasePrice = basePrice,
            Name = $"{name} of epicness",
            Rarity = Rarity
        };
    }

    public Equipment CreateArmor(string name, int basePrice)
    {
        return new ChestArmor
        {
            BasePrice = basePrice,
            Name = $"{name} of epicness",
            Rarity = Rarity
        };
    }
}