namespace design_patterns.models;

public class Icon
{
    private readonly string _filename;
    private byte[] _iconData = Array.Empty<byte>();

    public Icon(string filename)
    {
        _filename = filename;
        Load();
    }

    public void Display()
    {
        Console.WriteLine($"Displaying {_filename}. Size: {_iconData.Length} bytes");
    }

    private void Load()
    {
        var fullPath = Path.Combine("Assets", "icons", _filename);
        _iconData = File.ReadAllBytes(fullPath);
    }
}