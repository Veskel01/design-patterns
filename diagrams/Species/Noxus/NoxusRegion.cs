using diagrams.Interfaces;

namespace diagrams.Species.Noxus;

public class NoxusRegion : IRegion
{
    private const string Description = "Noxus Region Description";

    public string GetDescription()
    {
        return Description;
    }
}