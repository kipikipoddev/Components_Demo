namespace Components_Demo;

public interface IAction
{
    string Name { get; }

    bool Can { get; }

    void Do();
}