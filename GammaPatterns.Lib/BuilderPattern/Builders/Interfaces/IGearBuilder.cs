using GammaPatterns.Lib.Shared.Models;

namespace GammaPatterns.Lib.BuilderPattern.Builders.Interfaces;

public interface IGearBuilder
{
    List<Equipment> GetGear();
}