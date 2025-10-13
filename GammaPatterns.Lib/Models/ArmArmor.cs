using GammaPatterns.Lib.Enums;

namespace GammaPatterns.Lib.Models;

public class ArmArmor: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.Arms;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}