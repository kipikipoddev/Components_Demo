namespace Components_Demo;

public class Injure_Handler
    : Component, IHandler<Injure_Command>, IHandler<Heal_Command>
{
    public bool Is_Injured { get; private set; }

    public bool Is_Valid(Injure_Command cmd)
    {
        return !Is_Injured;
    }

    public void Handle(Injure_Command cmd)
    {
        Parent.Print_Action()
    }

    public bool Is_Valid(Heal_Command cmd)
    {
        return Is_Injured;
    }

    public void Handle(Heal_Command cmd)
    {
        Is_Injured = false;
    }
}