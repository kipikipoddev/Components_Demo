namespace Components_Demo;

public class Heal_Action : Action
{
    public override string Name => "walk";
    public override string Doing => "walking";
    protected override bool Add_Speed => false;

    public Heal_Action(IAction_Printer printer, Func<bool> can_func)
        : base(printer, can_func)
    {
    }
}