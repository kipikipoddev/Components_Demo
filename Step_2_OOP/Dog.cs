namespace Step_2_OOP;

public class Dog : Animal
{
    public Dog(Speed speed)
        : base(speed)
    {
        Can_Make_Sound = true;
        Can_Walk = true;
        Can_Swim = true;
    }

    public override void Make_Sound()
    {
        Write_Action("barking");
    }
}