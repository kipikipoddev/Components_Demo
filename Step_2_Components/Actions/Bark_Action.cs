
namespace Components_Demo;

public class Bark_Action : Action
{
    public override string Name => "bark";
    public override string Doing => "barking";
    protected override bool Add_Speed => false;

    public Bark_Action(IAction_Printer printer, Func<bool> can_func)
        : base(printer, can_func)
    {
    }
}