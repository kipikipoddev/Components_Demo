namespace Components_Demo;

public interface IEntity
{
    string Name { get; }
    Speed Speed { get; }
    IAction[] Actions { get; }
}