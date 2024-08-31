namespace Components_Demo;

public interface ICat : IAnimal
{
    bool Can_Meow { get; }
    void Meow();
}