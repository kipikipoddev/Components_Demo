
namespace Components_Better_Solution;

public class Swim_Component : Component, IHandler<Swim_Command>
{
    public void Handle(Swim_Command cmd)
    {
        new Print_Command(Parent, Actions.Swiming, true);
    }
}