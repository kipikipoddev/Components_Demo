namespace Components_Demo;

public interface IAction_Printer
{
    void Print_Action(IEntity entity, Actions action);
    void Print_Cannot(IEntity entity, Actions action);
}