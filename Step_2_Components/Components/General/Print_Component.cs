
namespace Step_2_Components;

public abstract class Print_Component : Component, IPrint_Component
{
    protected abstract void Print(string message);

    public void Print_Was(Actions_Description action)
    {
        Print("was", action);
    }

    public void Print_Cant(Actions action)
    {
        Print("can't", action);
    }

    private void Print(string middle, object action)
    {
        var name = Parent.Get<IName_Component>().Name;
        var action_str = action.ToString().ToLower();
        Print($"{name} {middle} {action_str}");
    }
}