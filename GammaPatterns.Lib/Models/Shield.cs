using GammaPatterns.Lib.Enums;

namespace GammaPatterns.Lib.Models;

public class Shield: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.LeftHand;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}

public class Quiver: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.LeftHand;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}