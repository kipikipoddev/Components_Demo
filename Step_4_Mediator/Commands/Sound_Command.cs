using Step_4_Mediator.Core;

namespace Step_4_Mediator.Commands;

public record Sound_Command : Command
{
    public Sound_Command(IComponents component) 
        : base(component)
    {
    }
}