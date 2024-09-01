namespace Components_Demo;

public class Meow_Action : Component, IAction_Component
{
    public string Name => "meow";
    public string Did => Name + "ed";
}