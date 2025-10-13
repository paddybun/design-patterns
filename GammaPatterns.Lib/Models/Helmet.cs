using GammaPatterns.Lib.Enums;

namespace GammaPatterns.Lib.Models;

public class Helmet: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.Head;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}