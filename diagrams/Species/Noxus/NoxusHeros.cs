using diagrams.Interfaces;

namespace diagrams.Species.Noxus;

public class NoxusHeros : IHeros
{
    private const string Description = "Noxus Heros Description";

    public string GetDescription()
    {
        return Description;
    }
}