using design_patterns.Enums;

namespace design_patterns.Interfaces;

public interface ICommand<in TArgs>
{
    CommandResult Execute(TArgs args);
}