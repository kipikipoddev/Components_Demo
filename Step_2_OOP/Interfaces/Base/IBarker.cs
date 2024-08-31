namespace Step_2_OOP;

public interface IBarker : IEntity
{
    bool Can_Bark { get; }
    void Bark();
}