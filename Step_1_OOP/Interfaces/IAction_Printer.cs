namespace Step_1_OOP;

public interface IAction_Printer
{
    void Print_Action(IEntity entity, Actions action, bool add_speed = false, string? extra = null);
    void Print_Cannot(IEntity entity, Actions action);
    void Print_Actions(IEntity entity);
}