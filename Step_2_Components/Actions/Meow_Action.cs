
namespace Components_Demo;

public class Meow_Action : Action
{
    public override string Name => "meow";
    public override string Doing => "meowing";
    protected override bool Add_Speed => false;

    public Meow_Action(IAction_Printer printer, Func<bool> can_func)
        : base(printer, can_func)
    {
    }
}