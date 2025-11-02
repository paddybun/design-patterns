using GammaPatterns.Lib.Shared.Enums;
using GammaPatterns.Lib.Shared.Models;

namespace GammaPatterns.Lib.AbstractFactoryPattern.Factories;

public class CommonEquipmentFactory: IEquipmentFactory
{
    public Rarity Rarity { get; init; } = Rarity.Common;

    public Equipment CreateWeapon(string name, int basePrice)
    {
        return new Weapon
        {
            BasePrice = basePrice,
            Name = name,
            Rarity = Rarity
        };
    }

    public Equipment CreateArmor(string name, int basePrice)
    {
        return new ChestArmor
        {
            BasePrice = basePrice,
            Name = name,
            Rarity = Rarity
        };
    }
}