using GammaPatterns.Lib.Shared.Enums;

namespace GammaPatterns.Lib.Shared.Models;

public class ChestArmor: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.Chest;

    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}