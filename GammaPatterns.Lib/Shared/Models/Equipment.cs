using GammaPatterns.Lib.Shared.Enums;

namespace GammaPatterns.Lib.Shared.Models;

public abstract class Equipment
{
    public abstract EquipmentSlot EquipmentSlot { get; init; }
    public Rarity Rarity { get; init; }
    
    public int BasePrice { get; init; }
    public int Affixes { get; init; }
    public required string Name { get; init; }

    public abstract int CalculatePrice();
}