namespace Step_5_Complex;

public class Walk_Component : Action_Component<Walk_Command>
{
    public override void Handle(Walk_Command cmd)
    {
        new Print_Action_Command(Parent, cmd.Action, cmd.Speed);
    }
}