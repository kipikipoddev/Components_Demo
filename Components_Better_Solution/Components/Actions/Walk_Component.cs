namespace Components_Better_Solution;

public class Walk_Component : Component, IHandler<Walk_Command>
{
    public void Handle(Walk_Command cmd)
    {
        new Print_Command(Parent, cmd.Was, true);
    }
}