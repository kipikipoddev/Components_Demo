
namespace Step_4_Files;

public record Print_Cant_Command(IComponents Components, Actions Action) : Command(Components)
{
}