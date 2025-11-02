using GammaPatterns.Lib.Shared.Enums;
using GammaPatterns.Lib.Shared.Models;

namespace GammaPatterns.Lib.BuilderPattern.Builders.Interfaces;

public interface IGearDirector
{
    List<Equipment> GetGear(Rarity rarity);
    List<Equipment> GetLegendaryWarriorWeaponSet(Rarity rarity);
}