namespace Components_Demo;

public interface IAction_Printer
{
    void Print_Action(IAction action, bool add_speed);
    void Print_Cannot(IAction action);
    void Print_Actions();
}