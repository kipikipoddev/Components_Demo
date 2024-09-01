namespace Components_Demo;

public interface IEntity
{
    string Name { get; }
    IEnumerable<Actions> Get_Actions();
}