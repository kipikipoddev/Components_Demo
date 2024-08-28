namespace Step_2_OOP;

public class Fish : Entity
{
    public override bool Can_Swim => true;

    public override void Swim(Speed speed)
    {
        Write($"swiming {Get_Speed(speed)}like a fish");
    }
}