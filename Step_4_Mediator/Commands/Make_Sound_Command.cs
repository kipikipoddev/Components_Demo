using Step_4_Mediator.Core;

namespace Step_4_Mediator.Commands;

public record Make_Sound_Command : Command
{
    public Make_Sound_Command(IComponents component) 
        : base(component)
    {
    }
}