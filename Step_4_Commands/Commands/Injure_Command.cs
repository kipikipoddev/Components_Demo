namespace Step_4_Commands.Commands;

public class Injure_Command : Command
{
    public Injure_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}
