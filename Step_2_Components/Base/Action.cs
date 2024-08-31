
namespace Components_Demo;

public class Action : IAction
{
    private readonly IAction_Printer printer;
    private readonly Func<bool> can_func;
    private readonly Action_Data data;

    public string Name => data.Name;
    public string Doing => data.Doing;
    public bool Can => can_func();

    public Action(IAction_Printer printer, Func<bool> can_func, Action_Data data)
    {
        this.printer = printer;
        this.can_func = can_func;
        this.data = data;
    }

    public void Do()
    {
        if (Can)
            printer.Print_Action(this, data.Add_Speed);
        else
            printer.Print_Cannot(this);
    }
}