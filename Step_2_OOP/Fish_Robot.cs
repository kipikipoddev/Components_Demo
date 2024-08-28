namespace Step_2_OOP;

public class Fish_Robot : Robot
{
    private readonly Fish fish;
    public override bool Can_Walk => false;
    public override bool Can_Swim => true;

    public Fish_Robot()
    {
        fish = new Fish { Name = Name };
    }

    public override void Swim(Speed speed)
    {
        Recharge();
        fish.Swim(speed);
    }
}