
namespace Components_Better_Solution;

[Add_Component(typeof(IHandler<Bark_Command>))]
public class Bark_Component : Component, IHandler<Bark_Command>
{
    public void Handle(Bark_Command cmd)
    {
        new Print_Command(Parent, Actions.Barking, true);
    }
}