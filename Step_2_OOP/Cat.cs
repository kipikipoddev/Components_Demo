namespace Step_2_OOP;

public class Cat : Entity
{
    public override bool Can_Make_Sound => true;
    public override bool Can_Walk => true;

    public override void Make_Sound()
    {
        Write("meowing");
    }

    public override void Walk()
    {
        Write("walking like a cat");
    }
}