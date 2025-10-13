using GammaPatterns.Lib.Enums;
using GammaPatterns.Lib.Models;

namespace GammaPatterns.Lib.BuilderPattern.Builders.Interfaces;

public interface IGearDirector
{
    List<Equipment> GetGear(Rarity rarity);
    List<Equipment> GetLegendaryWarriorWeaponSet(Rarity rarity);
}