namespace Step_1_OOP;

public interface IAction_Printer
{
    void Print_Action(IEntity entity, object action, bool add_speed = false, string? extra = null);
    void Print_Cannot(IEntity entity, object action);
    void Print_Actions(IEntity entity);
}