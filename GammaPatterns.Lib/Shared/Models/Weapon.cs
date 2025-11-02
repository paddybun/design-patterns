using GammaPatterns.Lib.Shared.Enums;

namespace GammaPatterns.Lib.Shared.Models;

public class Weapon: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.RightHand;
    public WeaponType WeaponType { get; init; }
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}