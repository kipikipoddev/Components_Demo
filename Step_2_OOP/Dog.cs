namespace Step_2_OOP;

public class Dog : Entity
{
    public override bool Can_Make_Sound => true;
    public override bool Can_Swim => true;
    public override bool Can_Walk => true;

    public override void Make_Sound()
    {
        Write("barking");
    }

    public override void Swim()
    {
        Write("swiming like a dog");
    }

    public override void Walk()
    {
        Write("walking like a dog");
    }
}