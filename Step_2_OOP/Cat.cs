namespace Step_2_OOP;

public class Cat : Animal
{
    public Cat(Speed speed)
        : base(speed)
    {
        Can_Make_Sound = true;
        Can_Walk = true;
    }

    public override void Make_Sound()
    {
        Write_Action("meowing");
    }
}