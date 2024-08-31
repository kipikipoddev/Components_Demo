
namespace Components_Demo;

public abstract class Action : IAction
{
    private readonly IAction_Printer printer;
    private readonly Func<bool> can_func;

    protected abstract bool Add_Speed { get; }

    public abstract string Name { get; }
    public abstract string Doing { get; }
    public bool Can => can_func();

    public Action(IAction_Printer printer, Func<bool> can_func)
    {
        this.printer = printer;
        this.can_func = can_func;
    }

    public virtual void Do()
    {
        if (Can)
            Perfrom();
        else
            printer.Print_Cannot(this);
    }

    protected virtual void Perfrom()
    {
        printer.Print_Action(this, Add_Speed);
    }
}