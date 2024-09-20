namespace Step_5_Final;

public class Walk_Component : Action_Component, IWalk_Component
{
    public void Walk()
    {
        if (Can_Walk())
            Print_Was(Actions_Description.Walking);
        else
            Print_Cant(Actions.Walk);
    }

    public bool Can_Walk()
    {
        return !Is_Disabled;
    }

    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Walk;
        }
    }
}