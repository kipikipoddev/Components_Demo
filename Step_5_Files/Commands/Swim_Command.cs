namespace Step_5_Files.Commands;

public class Swim_Command : Command
{
    public Swim_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}
