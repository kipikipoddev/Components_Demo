namespace Step_2_OOP;

public interface IEntity
{
    string Name { get; }
    bool Can_Swim { get; }
    bool Can_Make_Sound { get; }
    bool Can_Walk { get; }

    void Swim();

    void Make_Sound();

    void Injure();

    void Walk();

    void Write_Actions();
}