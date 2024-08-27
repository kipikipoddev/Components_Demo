using Step_4_Mediator.Core;

namespace Step_4_Mediator.Commands;

public record Swim_Command : Command
{
    public Swim_Command(IComponents component) 
        : base(component)
    {
    }
}
