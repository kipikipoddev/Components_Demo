using Step_5_Files.Core;

namespace Step_5_Files.Commands;

public record Sound_Command : Command
{
    public Sound_Command(IComponents component) 
        : base(component)
    {
    }
}