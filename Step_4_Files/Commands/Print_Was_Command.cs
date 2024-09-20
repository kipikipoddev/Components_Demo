
namespace Step_4_Files;

public record Print_Was_Command(IComponents Components, Actions_Description Action) : Command(Components)
{
}