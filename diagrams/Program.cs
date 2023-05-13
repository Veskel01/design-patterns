using diagrams;
using diagrams.Species.Ionia;
using diagrams.Species.Noxus;

var app = new App();

var noxusChampionFactory = new NoxusChampionFactory();
var ioniaChampionFactory = new IoniaChampionFactory();

void PrintAppProperties()
{
    var heros = app.GetHeros();
    var region = app.GetRegion();
    var role = app.GetRole();

    Console.WriteLine($"Heros: {heros?.GetDescription()}");
    Console.WriteLine($"Region: {region?.GetDescription()}");
    Console.WriteLine($"Role: {role?.GetDescription()}");
}

app.createChampion(noxusChampionFactory);
PrintAppProperties();

app.createChampion(ioniaChampionFactory);
PrintAppProperties();