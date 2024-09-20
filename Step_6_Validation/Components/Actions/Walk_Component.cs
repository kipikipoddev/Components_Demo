namespace Step_6_Validation;

public class Walk_Component : Component, IHandler<Walk_Command>, IWalk_Component
{
    public Walk_Component()
    {
        Mediator.Add_Handler(this);
    }
    
    public void Walk()
    {
        new Walk_Command(Parent).Send();
    }

    public bool Can_Walk()
    {
        return new Walk_Command(Parent).Is_Valid();
    }

    public void Handle(Walk_Command cmd)
    {
        new Print_Was_Command(Parent, Actions_Description.Walking);
    }

    public IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Walk;
        }
    }
}