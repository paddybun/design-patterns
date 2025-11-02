using GammaPatterns.Lib.Shared.Enums;
using GammaPatterns.Lib.Shared.Models;

namespace GammaPatterns.Lib.FactoryPattern.Factories;

public class CommonWeaponFactory : IWeaponFactory
{
    private const int MinAffixes = 0;
    private const int MaxAffixes = 0;
    
    public Equipment CreateWeapon(WeaponType type)
    {
        return new Weapon
        {
            Name = GetWeaponName(type),
            Rarity = Rarity.Common,
            WeaponType = type,
            Affixes = GetAffixCount(0)
        };
    }

    public Equipment CreateWithAffixes(WeaponType type, int affixes)
    {   
        return new Weapon
        {
            Name = GetWeaponName(type),
            Rarity = Rarity.Common,
            WeaponType = type,
            Affixes = GetAffixCount(affixes)
        };
    }

    private int GetAffixCount(int affixes)
    {
        return Math.Clamp(affixes, MinAffixes, MaxAffixes);
    }

    private string GetWeaponName(WeaponType weaponType)
    {
        return $"{nameof(Rarity.Common)} {weaponType.ToString()}";
    }
}