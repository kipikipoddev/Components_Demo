namespace Step_2_OOP;

public interface ICat : IAnimal
{
    bool Can_Meow { get; }
    void Meow();
}