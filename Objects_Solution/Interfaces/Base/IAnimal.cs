namespace Objects_Solution;

public interface IAnimal : IEntity
{
    bool Is_Injured { get; }
    void Injure();
    void Heal();
}