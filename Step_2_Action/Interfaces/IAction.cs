namespace Components_Demo;

public interface IAction
{
    string Name { get; }
    string Doing { get; }
    bool Can { get; }
    void Do();
}