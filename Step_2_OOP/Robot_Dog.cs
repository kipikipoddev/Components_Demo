namespace Step_2_OOP;

public class Robot_Dog : Robot
{
    private readonly Dog dog;
    public override bool Can_Swim => true;

    public Robot_Dog()
    {
        dog = new Dog { Name = Name };
    }

    public override void Make_Sound()
    {
        Recharge();
        dog.Make_Sound();
    }

    public override void Swim(Speed speed)
    {
        Recharge();
        dog.Swim(speed);
    }

    public override void Walk(Speed speed)
    {
        Recharge();
        dog.Walk(speed);
    }
}