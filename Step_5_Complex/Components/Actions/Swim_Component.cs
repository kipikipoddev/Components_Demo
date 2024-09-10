namespace Step_5_Complex;

public class Swim_Component : Action_Component<Swim_Command>
{
    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Swim;
        }
    }
}