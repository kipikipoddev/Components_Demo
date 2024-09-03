namespace Components_Better_Solution;

public class Meow_Component : Component, IHandler<Meow_Command>
{
    public void Handle(Meow_Command cmd)
    {
        new Print_Command(Parent, cmd.Was, true);
    }
}