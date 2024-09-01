namespace Components_Demo;

public interface IAnimal : IEntity
{
    bool Is_Injured { get; }
    void Injure();
    void Heal();
}