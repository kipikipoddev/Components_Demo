namespace Step_5_Actions;

public class Meow_Component : Action_Component, IMeow_Component
{
    public void Meow()
    {
        if (Can_Meow())
            Print_Was(Actions_Description.Meowing);
        else
            Print_Cant(Actions.Meow);
    }

    public bool Can_Meow()
    {
        return !Is_Disabled;
    }

    public override IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Meow;
        }
    }
}