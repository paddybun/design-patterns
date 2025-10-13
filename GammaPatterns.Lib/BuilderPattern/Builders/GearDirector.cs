using GammaPatterns.Lib.Enums;
using GammaPatterns.Lib.Models;

namespace GammaPatterns.Lib.BuilderPattern.Builders;

public class GearDirector(IEquipmentBuilder equipmentBuilder)
{
    public List<Equipment> GetGear(Rarity rarity) 
    {
        var rarityName = rarity.ToString();
        equipmentBuilder.WithHelmet($"{rarityName} Cap", Rarity.Common);
        equipmentBuilder.WithArmor($"{rarityName} Leather Armor", rarity);
        equipmentBuilder.WithArmArmor($"{rarityName} Leather Gloves", rarity);
        equipmentBuilder.WithLegArmor($"{rarityName} Leather Pants", rarity);
        equipmentBuilder.WithWeapon($"{rarityName} Dagger", rarity);
        return (equipmentBuilder as IGearBuilder)!.GetGear();
    }
    
    public List<Equipment> GetLegendaryWarriorWeaponSet(Rarity rarity) 
    {
        var rarityName = rarity.ToString();
        equipmentBuilder.WithWeapon($"{rarityName} Sword", rarity);
        equipmentBuilder.WithOffhand($"{rarityName} Shield", rarity);
        return (equipmentBuilder as IGearBuilder)!.GetGear();
    }
}