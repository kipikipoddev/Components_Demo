using Step_4_Mediator.Core;

namespace Step_4_Mediator.Commands;

public record Sound_Command : Command
{
    protected Sound_Command(IComponents component) 
        : base(component)
    {
    }
}