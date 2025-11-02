using GammaPatterns.Lib.Shared.Enums;

namespace GammaPatterns.Lib.BuilderPattern.Builders.Interfaces;

public interface ICostDirector
{
    int GetTotalCost(Rarity rarity);
}