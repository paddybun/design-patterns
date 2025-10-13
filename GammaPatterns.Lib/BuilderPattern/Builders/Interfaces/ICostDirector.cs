using GammaPatterns.Lib.Enums;

namespace GammaPatterns.Lib.BuilderPattern.Builders.Interfaces;

public interface ICostDirector
{
    int GetTotalCost(Rarity rarity);
}