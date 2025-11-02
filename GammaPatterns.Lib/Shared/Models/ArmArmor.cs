using GammaPatterns.Lib.Shared.Enums;

namespace GammaPatterns.Lib.Shared.Models;

public class ArmArmor: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.Arms;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}