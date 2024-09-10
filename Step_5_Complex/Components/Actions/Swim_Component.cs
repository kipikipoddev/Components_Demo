namespace Step_5_Complex;

public class Swim_Component : Action_Component<Swim_Command>, IAction_Component
{
    public override IEnumerable<Actions> Actions_Handling
    {
        get
        {
            yield return Actions.Swim;
        }
    }
}