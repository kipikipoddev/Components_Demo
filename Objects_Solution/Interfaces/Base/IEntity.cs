namespace Objects_Solution;

public interface IEntity
{
    string Name { get; }
    IEnumerable<Actions> Get_Actions();
}