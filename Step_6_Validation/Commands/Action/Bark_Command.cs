

namespace Step_6_Validation;

public record Bark_Command(IComponents Components) : Action_Command(Components, Actions.Bark)
{
}