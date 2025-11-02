using GammaPatterns.Lib.Shared.Enums;
using GammaPatterns.Lib.Shared.Models;

namespace GammaPatterns.Lib.AbstractFactoryPattern.Factories;

public interface IEquipmentFactory
{
    public Rarity Rarity { get; init; }
    public Equipment CreateWeapon(string name, int basePrice);
    public Equipment CreateArmor(string name, int basePrice);
}