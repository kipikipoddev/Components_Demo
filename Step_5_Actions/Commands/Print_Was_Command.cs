
namespace Step_5_Final;

public record Print_Was_Command(IComponents Components, Actions_Description Action) : Command(Components)
{
}