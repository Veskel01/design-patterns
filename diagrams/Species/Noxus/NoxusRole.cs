using diagrams.Interfaces;

namespace diagrams.Species.Noxus;

public class NoxusRole : IRole
{
    private const string Description = "Noxus Role Description";

    public string GetDescription()
    {
        return Description;
    }
}