namespace Components_Demo;

public class Did_Handler<T> : Component, IHandler<T>
    where T : Action_Command
{
    public void Handle(T cmd,  Cancel_Token token)
    {
        Parent.Print_Action(cmd.Did);
    }
}