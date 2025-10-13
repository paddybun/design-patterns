using GammaPatterns.Lib.Enums;

namespace GammaPatterns.Lib.Models;

public class LegArmor: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.Legs;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}