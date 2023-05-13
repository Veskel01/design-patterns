namespace diagrams.Interfaces;

public interface IChampionFactory
{
    IRegion CreateRegion();
    IHeros CreateHeros();
    IRole CreateRole();
}