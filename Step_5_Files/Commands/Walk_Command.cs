namespace Step_5_Files.Commands;

public class Walk_Command : Command
{
    public Walk_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}
