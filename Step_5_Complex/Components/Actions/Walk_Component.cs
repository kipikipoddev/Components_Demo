namespace Step_5_Complex;

public class Walk_Component : Action_Component<Walk_Command>
{
    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Walk;
        }
    }

    public override void Handle(Walk_Command cmd)
    {
        new Print_Action_Command(Parent, cmd.Action, true, cmd.Speed);
    }
}