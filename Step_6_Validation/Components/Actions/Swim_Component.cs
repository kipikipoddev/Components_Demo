namespace Step_6_Validation;

public class Swim_Component : Component, IHandler<Swim_Command>, ISwim_Component
{
    public Swim_Component()
    {
        Mediator.Add_Handler(this);
    }
    
    public void Swim()
    {
        new Swim_Command(Parent).Send();
    }

    public bool Can_Swim()
    {
        return new Swim_Command(Parent).Is_Valid();
    }

    public void Handle(Swim_Command cmd)
    {
        new Print_Was_Command(Parent, Actions_Description.Swiming);
    }

    public IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Swim;
        }
    }
}