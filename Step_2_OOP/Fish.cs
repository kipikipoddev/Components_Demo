namespace Step_2_OOP;

public class Fish : Animal
{
    public Fish(Speed speed)
        : base(speed)
    {
        Can_Swim = true;
    }
}