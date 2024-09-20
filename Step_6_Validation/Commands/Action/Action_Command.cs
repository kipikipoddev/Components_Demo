
namespace Step_6_Validation;

public record Action_Command(IComponents Components, Actions Action) : Command(Components, false)
{
    public override bool Send()
    {
        var is_valid = base.Send();
        if (!is_valid)
            new Print_Cant_Command(Components, Action);
        return is_valid;
    }
}