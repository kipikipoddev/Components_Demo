namespace Step_2_OOP;

public interface IEntity
{
    bool Can_Swim { get; }
    bool Can_Make_Sound { get; }
    bool Can_Walk { get; }

    void Swim();

    void Make_Sound();

    void Walk();
}