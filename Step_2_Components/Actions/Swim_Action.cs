namespace Components_Demo;

public class Swim_Action : Action
{
    public override string Name => "swim";
    public override string Doing => "swiming";
    protected override bool Add_Speed => false;

    public Swim_Action(IAction_Printer printer, Func<bool> can_func)
        : base(printer, can_func)
    {
    }
}