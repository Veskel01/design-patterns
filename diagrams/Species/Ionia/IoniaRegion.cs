using diagrams.Interfaces;

namespace diagrams.Species.Ionia;

public class IoniaRegion : IRegion
{
    private const string Description = "Ionia region description";

    public string GetDescription()
    {
        return Description;
    }
}