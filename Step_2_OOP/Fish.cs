namespace Step_2_OOP;

public class Fish : Entity
{
    public override bool Can_Swim => true;

    public override void Swim()
    {
        Write("swiming like a fish");
    }
}