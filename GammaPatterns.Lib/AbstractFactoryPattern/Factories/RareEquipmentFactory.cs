
using GammaPatterns.Lib.Enums;
using GammaPatterns.Lib.Models;

namespace GammaPatterns.Lib.AbstractFactoryPattern.Factories;

public class RareEquipmentFactory: IEquipmentFactory
{
    public Rarity Rarity { get; init; } = Rarity.Rare;
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