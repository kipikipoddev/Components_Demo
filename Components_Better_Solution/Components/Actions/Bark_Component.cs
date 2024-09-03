
namespace Components_Better_Solution;

public class Bark_Component : Component, IBark_Component, IHandler<Bark_Command>
{
    public void Handle(Bark_Command cmd)
    {
        Parent.Print_Was(Actions.Barking);
    }
}