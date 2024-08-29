namespace Step_4_Commands.Commands;

public class Repaire_Command : Command
{
    public Repaire_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}
