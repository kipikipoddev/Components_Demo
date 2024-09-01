namespace Components_Demo;

public class Injure_Handler<T> : Component, IHandler<T>
    where T : Action_Command
{
    public void Handle(T cmd, Cancel_Token t)
    {
        if (Parent.Is_Injured())
        {
            Parent.Print_Cannot(cmd.Name);
            t.Cancel();
        }
    }
}