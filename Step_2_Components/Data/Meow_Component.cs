namespace Components_Demo;

public class Meow_Component() : Component, IAction_Component, IHandler<Meow_Command>
{
    public string Name => "meow";
    public string Did => Name + "ed";

    public bool Is_Valid(Meow_Command cmd)
    {

    }

    public void Handle(Meow_Command cmd)
    {
        
    }
}

public static class Meow_Component_Ext
{
    public static void Meow(this IComponents components)
    {
        new Meow_Command(components);
    }
}