namespace Components_Demo;

public interface IEntity
{
    string Name { get; }
    Speed Speed { get; }

    bool Can_Swim { get; }
    void Swim();

    bool Can_Walk { get; }
    void Walk();

    IEnumerable<Actions> Get_Actions();
}