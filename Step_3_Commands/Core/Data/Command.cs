
namespace Step_3_Commands;

public abstract record Command(IComponents components)
{
    public virtual bool Is_Valid()
    {
        return Mediator.Validate(this);
    }

    public virtual bool Send()
    {
        var is_valid = Is_Valid();
        if (is_valid)
            Mediator.Send(this);
        return is_valid;
    }
}