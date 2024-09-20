
namespace Step_6_Validation;

public class Injure_Component : Component, IInjure_Component, IValidator<Action_Command>
{
    public bool Is_Injured { get; private set; }

    public Injure_Component()
    {
        Mediator.Add_Validator(this);
    }

    public bool Can_Heal()
    {
        return Is_Injured;
    }

    public bool Can_Injure()
    {
        return !Is_Injured;
    }

    public void Heal()
    {
        if (Can_Heal())
        {
            Is_Injured = false;
            new Print_Was_Command(Parent, Actions_Description.Healed);
        }
        else
            new Print_Cant_Command(Parent, Actions.Heal);
    }

    public void Injure()
    {
        if (Can_Injure())
        {
            Is_Injured = true;
            new Print_Was_Command(Parent, Actions_Description.Injured);
        }
        else
            new Print_Cant_Command(Parent, Actions.Injure);
    }

    public bool Is_Valid(Action_Command cmd)
    {
        return !Is_Injured;
    }

    public IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Heal;
            yield return Actions.Injure;
        }
    }
}