namespace Step_6_Validation;

public class Meow_Component : Component, IHandler<Meow_Command>, IMeow_Component
{
    public Meow_Component()
    {
        Mediator.Add_Handler(this);
    }

    public void Meow()
    {
        new Meow_Command(Parent).Send();
    }

    public bool Can_Meow()
    {
        return new Meow_Command(Parent).Is_Valid();
    }

    public void Handle(Meow_Command cmd)
    {
        new Print_Was_Command(Parent, Actions_Description.Meowing);
    }

    public IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Meow;
        }
    }
}