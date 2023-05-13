using diagrams.Interfaces;

namespace diagrams.Species.Noxus;

public class NoxusChampionFactory : IChampionFactory
{
    public IRegion CreateRegion()
    {
        return new NoxusRegion();
    }

    public IHeros CreateHeros()
    {
        return new NoxusHeros();
    }

    public IRole CreateRole()
    {
        return new NoxusRole();
    }
}