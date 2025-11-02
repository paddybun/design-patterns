using GammaPatterns.Lib.BuilderPattern.Builders.Interfaces;
using GammaPatterns.Lib.Shared.Enums;

namespace GammaPatterns.Lib.BuilderPattern.Builders;

public class CostDirector(IEquipmentBuilder equipmentBuilder) : ICostDirector
{
    public int GetTotalCost(Rarity rarity)
    {
        var rarityName = rarity.ToString();
        equipmentBuilder.WithHelmet($"{rarityName} Helmet", rarity);
        equipmentBuilder.WithArmor($"{rarityName} Chest Armor", rarity);
        equipmentBuilder.WithArmArmor($"{rarityName} Arm Armor", rarity);
        equipmentBuilder.WithLegArmor($"{rarityName} Leg Armor", rarity);
        equipmentBuilder.WithWeapon($"{rarityName} Sword", rarity);
        equipmentBuilder.WithOffhand($"{rarityName} Offhand", rarity);
        
        return (equipmentBuilder as ICostBuilder)!.GetGearPrice();
    }
}