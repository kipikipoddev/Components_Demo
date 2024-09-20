
namespace Step_5_Actions;

public record Print_Was_Command(IComponents Components, Actions_Description Action) : Command(Components)
{
}