namespace Components_Better_Solution;

public class Bark_Component : Component, IHandler<Bark_Command>
{
    public void Handle(Bark_Command cmd)
    {
        new Print_Command(Parent, cmd.Was, true);
    }
}