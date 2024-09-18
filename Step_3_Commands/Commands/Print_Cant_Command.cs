
namespace Step_3_Commands;

public record Print_Cant_Command(IComponents Components, Actions Action) : Command(Components)
{
}