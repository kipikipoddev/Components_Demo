namespace Step_2_OOP;

public class Robot_Dog : Robot
{
    private readonly Dog dog;

    public Robot_Dog(Speed speed)
    : base(speed)
    {
        Can_Swim = true;
        dog = new Dog(speed) { Name = Name };
    }

    public override void Make_Sound()
    {
        Check_Status();
        dog.Make_Sound();
    }

    public override void Swim()
    {
        Check_Status();
        dog.Swim();
    }

    public override void Walk()
    {
        Check_Status();
        dog.Walk();
    }
}