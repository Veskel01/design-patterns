using diagrams.Interfaces;

namespace diagrams;

public class App
{
    private IHeros? _heros;
    private IRegion? _region;
    private IRole? _role;

    public void createChampion(IChampionFactory factory)
    {
        SetHeros(factory.CreateHeros());
        SetRegion(factory.CreateRegion());
        SetRole(factory.CreateRole());
    }

    private void SetRegion(IRegion region)
    {
        _region = region;
    }

    public IRegion? GetRegion()
    {
        return _region;
    }

    private void SetRole(IRole role)
    {
        _role = role;
    }

    public IRole? GetRole()
    {
        return _role;
    }

    private void SetHeros(IHeros heros)
    {
        _heros = heros;
    }

    public IHeros? GetHeros()
    {
        return _heros;
    }
}