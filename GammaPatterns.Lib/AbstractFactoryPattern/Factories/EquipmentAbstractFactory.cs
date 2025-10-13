using GammaPatterns.Lib.Enums;
using GammaPatterns.Lib.Models;

namespace GammaPatterns.Lib.AbstractFactoryPattern.Factories;

public interface IEquipmentFactory
{
    public Rarity Rarity { get; init; }
    public Equipment CreateWeapon(string name, int basePrice);
    public Equipment CreateArmor(string name, int basePrice);
}