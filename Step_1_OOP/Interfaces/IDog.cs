namespace Step_1_OOP;

public interface IDog : IAnimal
{
    bool Can_Bark { get; }
    void Bark();
}