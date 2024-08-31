namespace Step_2_OOP;

public interface IDog : IAnimal
{
    bool Can_Bark { get; }
    void Bark();
}