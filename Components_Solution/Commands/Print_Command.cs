namespace Components_Solution;

public class Print_Command : Command
{
    public Action_Command Action { get; }
    public bool Is_Success { get; }

    public Print_Command(Action_Command action, bool is_success)
        : base(action.Components)
    {
        Action = action;
        Is_Success = is_success;
        Send(this);
    }
}