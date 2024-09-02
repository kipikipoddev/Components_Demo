namespace Objects_Solution;

public interface IAnimal : IEntity
{
    bool Is_Injured { get; }
    
    bool Can_Injure();
    void Injure();

    bool Can_Heal();
    void Heal();
}