using GammaPatterns.Lib.Enums;

namespace GammaPatterns.Lib.Models;

public abstract class Equipment
{
    public abstract EquipmentSlot EquipmentSlot { get; init; }
    public Rarity Rarity { get; init; }
    
    public int BasePrice { get; init; }
    public required string Name { get; init; }

    public abstract int CalculatePrice();
}