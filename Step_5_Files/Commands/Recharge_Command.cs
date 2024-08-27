using Step_5_Files.Core;
using Step_5_Files.Interfaces;

namespace Step_5_Files.Commands;

public record Recharge_Command : Command
{
    public Recharge_Command(IComponents component)
        : base(component, false)
    {
        if (!component.Charged())
            Send();
    }
}