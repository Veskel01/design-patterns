using diagrams.Interfaces;

namespace diagrams.Species.Ionia;

public class IoniaChampionFactory : IChampionFactory
{
    public IRegion CreateRegion()
    {
        return new IoniaRegion();
    }

    public IHeros CreateHeros()
    {
        return new IoniaHeros();
    }

    public IRole CreateRole()
    {
        return new IoniaRole();
    }
}