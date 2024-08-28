namespace Step_4_Commands.Commands;

public class No_Handler_Command : Command
{
    public Command Command { get; }

    public No_Handler_Command(Command command)
        : base(command.Components)
    {
        Command = command;
        Send(this);
    }
}
