using Step_4_Mediator.Core;

namespace Step_4_Mediator.Commands;

public record Walk_Command : Command
{
    public Walk_Command(IComponents component) 
        : base(component)
    {
    }
}
