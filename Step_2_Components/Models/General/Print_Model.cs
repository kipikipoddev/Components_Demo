
namespace Step_2_Components;

public abstract class Print_Model : IPrint_Model
{
    private readonly IName_Model name_model;

    protected abstract void Print(string message);
    
    public Print_Model(IName_Model name)
    {
        this.name_model = name;
    }
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
        var action_str = action.ToString().ToLower();
        Print($"{name_model.Name} {middle} {action_str}");
    }
}