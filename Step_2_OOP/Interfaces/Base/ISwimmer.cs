namespace Step_2_OOP;

public interface ISwimmer: IEntity
{
    bool Can_Swim { get; }
    void Swim();
}