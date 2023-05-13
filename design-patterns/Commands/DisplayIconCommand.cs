using design_patterns.Enums;
using design_patterns.Factories;
using design_patterns.Interfaces;

namespace design_patterns.Commands;

public class DisplayIconCommand : ICommand<string>
{
    private readonly IconFactory _iconFactory;

    public DisplayIconCommand(IconFactory iconFactory)
    {
        _iconFactory = iconFactory;
    }

    public CommandResult Execute(string filename)
    {
        var icon = _iconFactory.Create(filename);
        icon.Display();

        return CommandResult.Success;
    }
}