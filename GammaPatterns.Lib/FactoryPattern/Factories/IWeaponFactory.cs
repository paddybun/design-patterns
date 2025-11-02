using GammaPatterns.Lib.Shared.Enums;
using GammaPatterns.Lib.Shared.Models;

namespace GammaPatterns.Lib.FactoryPattern.Factories;

internal interface IWeaponFactory
{
    Equipment CreateWeapon (WeaponType type);
    Equipment CreateWithAffixes (WeaponType type, int affixes);
}