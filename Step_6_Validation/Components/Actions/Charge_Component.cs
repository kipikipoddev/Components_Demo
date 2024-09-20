
namespace Step_6_Validation;

public class Charge_Component : Component, ICharged_Component, IValidator<Action_Command>
{
    public bool Is_Charged { get; private set; }

    public Charge_Component()
    {
        Mediator.Add_Validator(this);
    }

    public bool Can_Charge()
    {
        return !Is_Charged;
    }

    public void Charge()
    {
        if (Can_Charge())
        {
            Is_Charged = true;
            new Print_Was_Command(Parent, Actions_Description.Charged);
        }
        else
            new Print_Cant_Command(Parent, Actions.Charge);
    }

    public bool Is_Valid(Action_Command cmd)
    {
        return Is_Charged;
    }

    public IEnumerable<Actions> Available_Actions
    {
        get
        {
            yield return Actions.Charge;
        }
    }
}