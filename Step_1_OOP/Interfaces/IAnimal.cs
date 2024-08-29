namespace Step_1_OOP;

public interface IAnimal : IEntity
{
    bool Is_Injured { get; }
    void Injure();
    void Heal();
}