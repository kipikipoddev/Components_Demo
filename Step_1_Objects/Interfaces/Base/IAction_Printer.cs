namespace Step_1_Objects;

public interface IAction_Printer
{
    void Print_Action(IEntity entity, Actions action);
    void Print_Cant(IEntity entity, Actions action);
}