namespace Step_4_Mediator.Core.Events;

public record Command : Event
{
    public Command(object model, bool auto_send = true)
        : base(model, auto_send)
    {
    }

    protected virtual bool Is_Valid()
    {
        return Model_Object != null;
    }

    protected override void Start()
    {
        base.Start();
        if (!Is_Valid())
            throw new Exception("Command not valid");
    }

    protected override void End()
    {
        if (Indentation == 1)
            new Update_Event();
        base.End();
    }
}