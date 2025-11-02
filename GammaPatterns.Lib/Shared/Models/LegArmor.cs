using GammaPatterns.Lib.Shared.Enums;

namespace GammaPatterns.Lib.Shared.Models;

public class LegArmor: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.Legs;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}