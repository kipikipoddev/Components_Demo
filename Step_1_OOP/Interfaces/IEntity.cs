namespace Step_1_OOP;

public interface IEntity
{
    string Name { get; }
    Speed Speed { get; }

    bool Can_Swim { get; }
    bool Can_Make_Sound { get; }
    bool Can_Walk { get; }

    void Swim();
    void Make_Sound();
    void Walk();
}