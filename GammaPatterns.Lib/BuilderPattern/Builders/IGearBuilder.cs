using GammaPatterns.Lib.Models;

namespace GammaPatterns.Lib.BuilderPattern.Builders;

public interface IGearBuilder
{
    List<Equipment> GetGear();
}