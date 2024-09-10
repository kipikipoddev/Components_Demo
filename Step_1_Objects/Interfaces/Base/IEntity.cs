namespace Step_1_Objects;

public interface IEntity
{
    string Name { get; }

    IEnumerable<Actions> Available_Actions { get; }
}