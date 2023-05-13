using diagrams.Interfaces;

namespace diagrams.Species.Ionia;

public class IoniaHeros : IHeros
{
    private const string Description = "Ionia heros description";

    public string GetDescription()
    {
        return Description;
    }
}