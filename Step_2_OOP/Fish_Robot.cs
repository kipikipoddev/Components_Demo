namespace Step_2_OOP;

public class Fish_Robot : Robot
{
    private readonly Fish fish;

    public Fish_Robot(Speed speed)
    : base(speed)
    {
        Can_Swim = true;
        Can_Walk = false;
        fish = new Fish(speed) { Name = Name };
    }

    public override void Swim()
    {
        Check_Status();
        fish.Swim();
    }
}