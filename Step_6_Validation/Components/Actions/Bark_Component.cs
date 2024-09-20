namespace Step_6_Validation;

public class Bark_Component : Component, IHandler<Bark_Command>, IBark_Component
{
    public Bark_Component()
    {
        Mediator.Add_Handler(this);
    }
    
    public void Bark()
    {
        new Bark_Command(Parent).Send();
    }

    public bool Can_Bark()
    {
        return new Bark_Command(Parent).Is_Valid();
    }

    public void Handle(Bark_Command cmd)
    {
        new Print_Was_Command(Parent, Actions_Description.Barking);
    }

    public IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Bark;
        }
    }
}