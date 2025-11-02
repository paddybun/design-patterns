using GammaPatterns.Lib.BuilderPattern.Builders;
using GammaPatterns.Lib.Shared.Enums;
using GammaPatterns.Lib.Shared.Models;

namespace GammaPatterns.Lib.BuilderPattern;

public class BuilderPatternUsageExample()
{
    public List<Equipment> BuildWarriorGear()
    {
        var director = new GearDirector(new WarriorEquipmentBuilder());
        return director.GetGear(Rarity.Common);
    }
    
    public List<Equipment> BuildRogueGear()
    {
        var director = new GearDirector(new RogueEquipmentBuilder());
        return director.GetGear(Rarity.Uncommon);
    }
    
    public int GetCommonWarriorGearPrice()
    {
        var costDirector = new CostDirector(new WarriorEquipmentBuilder());
        return costDirector.GetTotalCost(Rarity.Common);
    }
}