using GammaPatterns.Lib.Enums;

namespace GammaPatterns.Lib.BuilderPattern.Builders;

public interface IEquipmentBuilder
{
    void WithHelmet(string name, Rarity rarity);
    void WithArmor(string name, Rarity rarity);
    void WithArmArmor(string name, Rarity rarity);
    void WithLegArmor(string name, Rarity rarity);
    void WithWeapon(string name, Rarity rarity);
    void WithOffhand(string name, Rarity rarity);
}