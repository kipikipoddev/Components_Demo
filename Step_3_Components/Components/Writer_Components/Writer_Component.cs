using Step_3_Components.Enums;

namespace Step_3_Components;

public class Writer_Component : Component, IWriter_Component
{
    public void Write_Actions()
    {
        var actions = (Parent.Can_Walk() ? "Walk, " : string.Empty) +
                    (Parent.Can_Make_Sound() ? "Make sound, " : string.Empty) +
                    (Parent.Can_Swim() ? "Swim, " : string.Empty);
        actions = actions.Remove(actions.Length - 2, 2);
        Console.WriteLine(Parent.Name() + " can: " + actions);
    }

    public virtual void Write_Action(string action)
    {
        Console.WriteLine($"{Parent.Name()} is {action}");
    }

    public void Write_Action_Like(string action)
    {
        Console.WriteLine($"{Parent.Name()} is {action}{Get_Speed()} like a {Get_Type()}");
    }

    public void Write_Cannot(string action)
    {
        Console.WriteLine(Parent.Name() + " cannot " + action);
    }

    private string Get_Speed()
    {
        return Parent.Speed() switch
        {
            Speed.Slow => " slowly",
            Speed.Fast => " fast",
            _ => string.Empty,
        };
    }

    private string Get_Type()
    {
        return Parent.Type().ToString().ToLower();
    }
}