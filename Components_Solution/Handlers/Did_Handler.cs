namespace Components_Solution;

public class Did_Handler<T> : Component, IHandler<T>
    where T : Action_Command
{
    public void Handle(T cmd, Action next)
    {
        new Print_Command(cmd, true);
        next();
    }
}