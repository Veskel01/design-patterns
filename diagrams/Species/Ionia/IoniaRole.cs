using diagrams.Interfaces;

namespace diagrams.Species.Ionia;

public class IoniaRole : IRole
{
    private const string Description = "Ionia role description";

    public string GetDescription()
    {
        return Description;
    }
}