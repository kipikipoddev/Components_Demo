namespace Components_Demo;

public interface IAnimal : IEntity
{
    bool Is_Injured { get; }
    bool Can_Injure { get; }
    bool Can_Heal { get; }

    void Injure();
    void Heal();
}