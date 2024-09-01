namespace Components_Demo;

public class Meow_Component : Component, IAction_Component
{
    public string Name => "meow";
    public string Did => Name + "ed";
}