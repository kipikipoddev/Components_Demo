using Step_5_Files.Core;

namespace Step_5_Files.Commands;

public record Swim_Command : Command
{
    public Swim_Command(IComponents component) 
        : base(component)
    {
    }
}
