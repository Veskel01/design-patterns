using design_patterns.models;

namespace design_patterns.Factories;

public class IconFactory
{
    private readonly Dictionary<string, Icon> _icons = new();

    public Icon Create(string filename)
    {
        if (_icons.TryGetValue(filename, out var icon)) return icon;

        icon = new Icon(filename);

        _icons.Add(filename, icon);

        return icon;
    }
}