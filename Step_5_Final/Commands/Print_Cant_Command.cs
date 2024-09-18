
namespace Step_5_Final;

public record Print_Cant_Command(IComponents Components, Actions Action) : Command(Components)
{
}