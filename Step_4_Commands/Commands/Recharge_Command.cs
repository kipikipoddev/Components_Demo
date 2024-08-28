namespace Step_4_Commands.Commands;

public class Recharge_Command : Command
{
    public Recharge_Command(IComponents component)
        : base(component)
    {
        Send(this);
    }
}