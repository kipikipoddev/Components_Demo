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

    public override void Swim(Speed speed)
    {
        Write($"swiming {Get_Speed(speed)}like a dog");
    }

    public override void Walk(Speed speed)
    {
        Write($"walking {Get_Speed(speed)}like a dog");
    }
}