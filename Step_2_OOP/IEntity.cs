namespace Step_2_OOP;

public interface IEntity
{
    bool Can_Swim { get; }
    bool Can_Make_Sound { get; }
    bool Can_Walk { get; }

    void Swim(Speed speed = Speed.Normal);

    void Make_Sound();

    void Walk(Speed speed = Speed.Normal);
}