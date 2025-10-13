using GammaPatterns.Lib.Enums;

namespace GammaPatterns.Lib.Models;

public class Weapon: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.RightHand;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}