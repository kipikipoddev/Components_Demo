namespace Components_Demo;

public class No_Handler_Command : Command
{
    public Command Command { get; }

    public No_Handler_Command(Command cmd) : base(cmd.Components)
    {
        Command = cmd;
    }
}
