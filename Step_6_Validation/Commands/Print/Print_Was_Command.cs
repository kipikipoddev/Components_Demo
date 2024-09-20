
namespace Step_6_Validation;

public record Print_Was_Command(IComponents Components, Actions_Description Action) : Command(Components)
{
}