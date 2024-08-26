namespace Step_2_OOP;

public class Robot_Dog : Robot
{
    protected readonly Dog Dog;

    public Robot_Dog()
    {
        Dog = new Dog { Name = Name };
    }

    public override void Make_Sound()
    {
        Recharge();
        Dog.Make_Sound();
    }
}