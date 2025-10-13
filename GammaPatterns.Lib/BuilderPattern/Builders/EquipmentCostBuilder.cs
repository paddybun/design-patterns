using GammaPatterns.Lib.BuilderPattern.Builders.Interfaces;
using GammaPatterns.Lib.Enums;
using GammaPatterns.Lib.Models;

namespace GammaPatterns.Lib.BuilderPattern.Builders;

public class EquipmentCostBuilder: IEquipmentBuilder, ICostBuilder
{
    private List<Equipment> _gear = [];
    
    public int GetGearPrice() => _gear.Sum(x => x.CalculatePrice());
    
    public void WithHelmet(string name, Rarity rarity)
    {
        _gear.Add(new Helmet
        {
            Name = name,
            Rarity = rarity,
            BasePrice = 50
        });
    }
    
    public void WithArmor(string name, Rarity rarity)
    {
        _gear.Add(new ChestArmor
        {
            Name = name,
            Rarity = rarity,
            BasePrice = 100
        });
    }
    
    public void WithArmArmor(string name, Rarity rarity)
    {
        _gear.Add(new ArmArmor
        {
            Name = name,
            Rarity = rarity,
            BasePrice = 75
        });
    }
    
    public void WithLegArmor(string name, Rarity rarity)
    {
        _gear.Add(new LegArmor
        {
            Name = name,
            Rarity = rarity,
            BasePrice = 80
        });
    }
    
    public void WithWeapon(string name, Rarity rarity)
    {
        _gear.Add(new Weapon
        {
            Name = name,
            Rarity = rarity,
            BasePrice = 150
        });
    }
    
    public void WithOffhand(string name, Rarity rarity)
    {
        _gear.Add(new Shield
        {
            Name = name,
            Rarity = rarity,
            BasePrice = 120
        });
    }
}