namespace Components_Demo;

public interface IAction_Printer
{
    void Print_Action(IAction_Component action, bool add_speed);
    void Print_Cannot(IAction_Component action);
    void Print_Actions(IComponents components);
}