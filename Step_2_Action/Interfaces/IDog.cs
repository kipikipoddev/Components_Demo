namespace Components_Demo;

public interface IDog : IAnimal
{
    bool Can_Bark { get; }
    void Bark();
}