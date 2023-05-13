using design_patterns.Commands;
using design_patterns.Factories;

void Bootstrap()
{
    var iconFactory = new IconFactory();
    var command = new DisplayIconCommand(iconFactory);

    command.Execute("dog-icon.png");
}


Bootstrap();