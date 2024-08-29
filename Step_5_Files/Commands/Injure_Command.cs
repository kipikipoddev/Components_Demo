namespace Step_5_Files.Commands;

public class Injure_Command : Command
{
    public Injure_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}
