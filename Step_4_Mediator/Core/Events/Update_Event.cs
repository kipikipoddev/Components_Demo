namespace Step_4_Mediator.Core;

public record Update_Event : Event
{
    protected override void End()
    {
        new UI_Update_Event();
        base.End();
    }
}