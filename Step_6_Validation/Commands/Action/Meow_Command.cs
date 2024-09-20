

namespace Step_6_Validation;

public record Meow_Command(IComponents Components) : Action_Command(Components, Actions.Meow)
{
}