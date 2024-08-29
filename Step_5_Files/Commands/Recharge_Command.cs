namespace Step_5_Files.Commands;

public class Recharge_Command : Command
{
    public Recharge_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}