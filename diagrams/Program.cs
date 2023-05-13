using diagrams;
using diagrams.Species.Noxus;

var app = new App();

app.createChampion(new NoxusChampionFactory());

var heros = app.GetHeros();
var region = app.GetRegion();
var role = app.GetRole();

Console.WriteLine($"Heros: {heros?.GetDescription()}");
Console.WriteLine($"Region: {region?.GetDescription()}");
Console.WriteLine($"Role: {role?.GetDescription()}");