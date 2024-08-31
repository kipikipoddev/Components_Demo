namespace Step_2_OOP;

public interface IEntity
{
    string Name { get; }
    Speed Speed { get; }
    IEnumerable<Actions> Actions_Possible { get; }
}