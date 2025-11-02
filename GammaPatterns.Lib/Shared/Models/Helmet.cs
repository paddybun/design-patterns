using GammaPatterns.Lib.Shared.Enums;

namespace GammaPatterns.Lib.Shared.Models;

public class Helmet: Equipment
{
    public override EquipmentSlot EquipmentSlot { get; init; } = EquipmentSlot.Head;
    public override int CalculatePrice()
    {
        return (int)Rarity * BasePrice;
    }
}