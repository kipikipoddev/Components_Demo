namespace Components_Solution;

[Action(Actions.Bark, Actions.Barking)]
public class Bark_Command : Action_Command
{
    public Bark_Command(IComponents components)
        : base(components)
    {
        Send(this);
    }
}
